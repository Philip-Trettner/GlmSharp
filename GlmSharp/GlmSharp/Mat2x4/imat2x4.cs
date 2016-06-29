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
    /// A matrix of type int with 2 columns and 4 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct imat2x4 : IReadOnlyList<int>, IEquatable<imat2x4>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public int m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public int m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public int m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public int m03;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public int m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public int m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public int m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public int m13;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public imat2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13)
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
        /// Constructs this matrix from a imat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0;
            this.m13 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a imat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0;
            this.m13 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a imat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0;
            this.m13 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a imat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a imat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a imat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a imat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat2x4 m)
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
        /// Constructs this matrix from a imat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat3x4 m)
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
        /// Constructs this matrix from a imat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(imat4 m)
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
        public imat2x4(ivec2 c0, ivec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0;
            this.m13 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(ivec3 c0, ivec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public imat2x4(ivec4 c0, ivec4 c1)
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
        public int[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public int[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public ivec4 Column0
        {
            get
            {
                return new ivec4(m00, m01, m02, m03);
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
        public ivec4 Column1
        {
            get
            {
                return new ivec4(m10, m11, m12, m13);
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
        public ivec2 Row0
        {
            get
            {
                return new ivec2(m00, m10);
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
        public ivec2 Row1
        {
            get
            {
                return new ivec2(m01, m11);
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
        public ivec2 Row2
        {
            get
            {
                return new ivec2(m02, m12);
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
        public ivec2 Row3
        {
            get
            {
                return new ivec2(m03, m13);
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
        public static imat2x4 Zero { get; } = new imat2x4(0, 0, 0, 0, 0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static imat2x4 Ones { get; } = new imat2x4(1, 1, 1, 1, 1, 1, 1, 1);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static imat2x4 Identity { get; } = new imat2x4(1, 0, 0, 0, 0, 1, 0, 0);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static imat2x4 AllMaxValue { get; } = new imat2x4(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static imat2x4 DiagonalMaxValue { get; } = new imat2x4(int.MaxValue, 0, 0, 0, 0, int.MaxValue, 0, 0);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static imat2x4 AllMinValue { get; } = new imat2x4(int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static imat2x4 DiagonalMinValue { get; } = new imat2x4(int.MinValue, 0, 0, 0, 0, int.MinValue, 0, 0);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<int> GetEnumerator()
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
        public int this[int fieldIndex]
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
        public int this[int col, int row]
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
        public bool Equals(imat2x4 rhs) => (((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m02.Equals(rhs.m02) && m03.Equals(rhs.m03))) && ((m10.Equals(rhs.m10) && m11.Equals(rhs.m11)) && (m12.Equals(rhs.m12) && m13.Equals(rhs.m13))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is imat2x4 && Equals((imat2x4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(imat2x4 lhs, imat2x4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(imat2x4 lhs, imat2x4 rhs) => !lhs.Equals(rhs);
        
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
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public imat4x2 Transposed => new imat4x2(m00, m10, m01, m11, m02, m12, m03, m13);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public int MinElement => Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(m00, m01), m02), m03), m10), m11), m12), m13);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public int MaxElement => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00, m01), m02), m03), m10), m11), m12), m13);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public float Length => (float)Math.Sqrt((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))));
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public float LengthSqr => (((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13)));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public int Sum => (((m00 + m01) + (m02 + m03)) + ((m10 + m11) + (m12 + m13)));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public float Norm => (float)Math.Sqrt((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public float Norm1 => (((Math.Abs(m00) + Math.Abs(m01)) + (Math.Abs(m02) + Math.Abs(m03))) + ((Math.Abs(m10) + Math.Abs(m11)) + (Math.Abs(m12) + Math.Abs(m13))));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public int NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(m00), Math.Abs(m01)), Math.Abs(m02)), Math.Abs(m03)), Math.Abs(m10)), Math.Abs(m11)), Math.Abs(m12)), Math.Abs(m13));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow((((Math.Pow((double)Math.Abs(m00), p) + Math.Pow((double)Math.Abs(m01), p)) + (Math.Pow((double)Math.Abs(m02), p) + Math.Pow((double)Math.Abs(m03), p))) + ((Math.Pow((double)Math.Abs(m10), p) + Math.Pow((double)Math.Abs(m11), p)) + (Math.Pow((double)Math.Abs(m12), p) + Math.Pow((double)Math.Abs(m13), p)))), 1 / p);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication imat2x4 * imat2 -> imat2x4.
        /// </summary>
        public static imat2x4 operator*(imat2x4 lhs, imat2 rhs) => new imat2x4((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11), (lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication imat2x4 * imat3x2 -> imat3x4.
        /// </summary>
        public static imat3x4 operator*(imat2x4 lhs, imat3x2 rhs) => new imat3x4((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11), (lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21), (lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21), (lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication imat2x4 * imat4x2 -> imat4.
        /// </summary>
        public static imat4 operator*(imat2x4 lhs, imat4x2 rhs) => new imat4((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11), (lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21), (lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21), (lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21), (lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31), (lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31), (lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31), (lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static ivec4 operator*(imat2x4 m, ivec2 v) => new ivec4((m.m00 * v.x + m.m10 * v.y), (m.m01 * v.x + m.m11 * v.y), (m.m02 * v.x + m.m12 * v.y), (m.m03 * v.x + m.m13 * v.y));
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static imat2x4 CompMul(imat2x4 A, imat2x4 B) => new imat2x4(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m03 * B.m03, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12, A.m13 * B.m13);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static imat2x4 CompDiv(imat2x4 A, imat2x4 B) => new imat2x4(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m03 / B.m03, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12, A.m13 / B.m13);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static imat2x4 CompAdd(imat2x4 A, imat2x4 B) => new imat2x4(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m03 + B.m03, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12, A.m13 + B.m13);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static imat2x4 CompSub(imat2x4 A, imat2x4 B) => new imat2x4(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m03 - B.m03, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12, A.m13 - B.m13);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static imat2x4 operator+(imat2x4 lhs, imat2x4 rhs) => new imat2x4(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m03 + rhs.m03, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static imat2x4 operator+(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m03 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m13 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static imat2x4 operator+(int lhs, imat2x4 rhs) => new imat2x4(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m03, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m13);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static imat2x4 operator-(imat2x4 lhs, imat2x4 rhs) => new imat2x4(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m03 - rhs.m03, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static imat2x4 operator-(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m03 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m13 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static imat2x4 operator-(int lhs, imat2x4 rhs) => new imat2x4(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m03, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m13);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static imat2x4 operator/(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m03 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs, lhs.m13 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static imat2x4 operator/(int lhs, imat2x4 rhs) => new imat2x4(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m03, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12, lhs / rhs.m13);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static imat2x4 operator*(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m03 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs, lhs.m13 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static imat2x4 operator*(int lhs, imat2x4 rhs) => new imat2x4(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m03, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12, lhs * rhs.m13);
        
        /// <summary>
        /// Executes a component-wise % (modulo).
        /// </summary>
        public static imat2x4 operator%(imat2x4 lhs, imat2x4 rhs) => new imat2x4(lhs.m00 % rhs.m00, lhs.m01 % rhs.m01, lhs.m02 % rhs.m02, lhs.m03 % rhs.m03, lhs.m10 % rhs.m10, lhs.m11 % rhs.m11, lhs.m12 % rhs.m12, lhs.m13 % rhs.m13);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static imat2x4 operator%(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 % rhs, lhs.m01 % rhs, lhs.m02 % rhs, lhs.m03 % rhs, lhs.m10 % rhs, lhs.m11 % rhs, lhs.m12 % rhs, lhs.m13 % rhs);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static imat2x4 operator%(int lhs, imat2x4 rhs) => new imat2x4(lhs % rhs.m00, lhs % rhs.m01, lhs % rhs.m02, lhs % rhs.m03, lhs % rhs.m10, lhs % rhs.m11, lhs % rhs.m12, lhs % rhs.m13);
        
        /// <summary>
        /// Executes a component-wise ^ (xor).
        /// </summary>
        public static imat2x4 operator^(imat2x4 lhs, imat2x4 rhs) => new imat2x4(lhs.m00 ^ rhs.m00, lhs.m01 ^ rhs.m01, lhs.m02 ^ rhs.m02, lhs.m03 ^ rhs.m03, lhs.m10 ^ rhs.m10, lhs.m11 ^ rhs.m11, lhs.m12 ^ rhs.m12, lhs.m13 ^ rhs.m13);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static imat2x4 operator^(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 ^ rhs, lhs.m01 ^ rhs, lhs.m02 ^ rhs, lhs.m03 ^ rhs, lhs.m10 ^ rhs, lhs.m11 ^ rhs, lhs.m12 ^ rhs, lhs.m13 ^ rhs);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static imat2x4 operator^(int lhs, imat2x4 rhs) => new imat2x4(lhs ^ rhs.m00, lhs ^ rhs.m01, lhs ^ rhs.m02, lhs ^ rhs.m03, lhs ^ rhs.m10, lhs ^ rhs.m11, lhs ^ rhs.m12, lhs ^ rhs.m13);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or).
        /// </summary>
        public static imat2x4 operator|(imat2x4 lhs, imat2x4 rhs) => new imat2x4(lhs.m00 | rhs.m00, lhs.m01 | rhs.m01, lhs.m02 | rhs.m02, lhs.m03 | rhs.m03, lhs.m10 | rhs.m10, lhs.m11 | rhs.m11, lhs.m12 | rhs.m12, lhs.m13 | rhs.m13);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static imat2x4 operator|(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 | rhs, lhs.m01 | rhs, lhs.m02 | rhs, lhs.m03 | rhs, lhs.m10 | rhs, lhs.m11 | rhs, lhs.m12 | rhs, lhs.m13 | rhs);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static imat2x4 operator|(int lhs, imat2x4 rhs) => new imat2x4(lhs | rhs.m00, lhs | rhs.m01, lhs | rhs.m02, lhs | rhs.m03, lhs | rhs.m10, lhs | rhs.m11, lhs | rhs.m12, lhs | rhs.m13);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and).
        /// </summary>
        public static imat2x4 operator&(imat2x4 lhs, imat2x4 rhs) => new imat2x4(lhs.m00 & rhs.m00, lhs.m01 & rhs.m01, lhs.m02 & rhs.m02, lhs.m03 & rhs.m03, lhs.m10 & rhs.m10, lhs.m11 & rhs.m11, lhs.m12 & rhs.m12, lhs.m13 & rhs.m13);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and) with a scalar.
        /// </summary>
        public static imat2x4 operator&(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 & rhs, lhs.m01 & rhs, lhs.m02 & rhs, lhs.m03 & rhs, lhs.m10 & rhs, lhs.m11 & rhs, lhs.m12 & rhs, lhs.m13 & rhs);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and) with a scalar.
        /// </summary>
        public static imat2x4 operator&(int lhs, imat2x4 rhs) => new imat2x4(lhs & rhs.m00, lhs & rhs.m01, lhs & rhs.m02, lhs & rhs.m03, lhs & rhs.m10, lhs & rhs.m11, lhs & rhs.m12, lhs & rhs.m13);
        
        /// <summary>
        /// Executes a component-wise left-shift with a scalar.
        /// </summary>
        public static imat2x4 operator<<(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 << rhs, lhs.m01 << rhs, lhs.m02 << rhs, lhs.m03 << rhs, lhs.m10 << rhs, lhs.m11 << rhs, lhs.m12 << rhs, lhs.m13 << rhs);
        
        /// <summary>
        /// Executes a component-wise right-shift with a scalar.
        /// </summary>
        public static imat2x4 operator>>(imat2x4 lhs, int rhs) => new imat2x4(lhs.m00 >> rhs, lhs.m01 >> rhs, lhs.m02 >> rhs, lhs.m03 >> rhs, lhs.m10 >> rhs, lhs.m11 >> rhs, lhs.m12 >> rhs, lhs.m13 >> rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat2x4 operator<(imat2x4 lhs, imat2x4 rhs) => new bmat2x4(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m02 < rhs.m02, lhs.m03 < rhs.m03, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11, lhs.m12 < rhs.m12, lhs.m13 < rhs.m13);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator<(imat2x4 lhs, int rhs) => new bmat2x4(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m02 < rhs, lhs.m03 < rhs, lhs.m10 < rhs, lhs.m11 < rhs, lhs.m12 < rhs, lhs.m13 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator<(int lhs, imat2x4 rhs) => new bmat2x4(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m02, lhs < rhs.m03, lhs < rhs.m10, lhs < rhs.m11, lhs < rhs.m12, lhs < rhs.m13);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat2x4 operator<=(imat2x4 lhs, imat2x4 rhs) => new bmat2x4(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m02 <= rhs.m02, lhs.m03 <= rhs.m03, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11, lhs.m12 <= rhs.m12, lhs.m13 <= rhs.m13);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator<=(imat2x4 lhs, int rhs) => new bmat2x4(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m02 <= rhs, lhs.m03 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs, lhs.m12 <= rhs, lhs.m13 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator<=(int lhs, imat2x4 rhs) => new bmat2x4(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m02, lhs <= rhs.m03, lhs <= rhs.m10, lhs <= rhs.m11, lhs <= rhs.m12, lhs <= rhs.m13);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat2x4 operator>(imat2x4 lhs, imat2x4 rhs) => new bmat2x4(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m02 > rhs.m02, lhs.m03 > rhs.m03, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11, lhs.m12 > rhs.m12, lhs.m13 > rhs.m13);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator>(imat2x4 lhs, int rhs) => new bmat2x4(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m02 > rhs, lhs.m03 > rhs, lhs.m10 > rhs, lhs.m11 > rhs, lhs.m12 > rhs, lhs.m13 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator>(int lhs, imat2x4 rhs) => new bmat2x4(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m02, lhs > rhs.m03, lhs > rhs.m10, lhs > rhs.m11, lhs > rhs.m12, lhs > rhs.m13);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat2x4 operator>=(imat2x4 lhs, imat2x4 rhs) => new bmat2x4(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m02 >= rhs.m02, lhs.m03 >= rhs.m03, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11, lhs.m12 >= rhs.m12, lhs.m13 >= rhs.m13);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator>=(imat2x4 lhs, int rhs) => new bmat2x4(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m02 >= rhs, lhs.m03 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs, lhs.m12 >= rhs, lhs.m13 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator>=(int lhs, imat2x4 rhs) => new bmat2x4(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m02, lhs >= rhs.m03, lhs >= rhs.m10, lhs >= rhs.m11, lhs >= rhs.m12, lhs >= rhs.m13);
    }
}
