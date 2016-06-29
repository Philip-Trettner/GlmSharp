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
    /// A matrix of type long with 2 columns and 2 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct lmat2 : IReadOnlyList<long>, IEquatable<lmat2>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public long m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public long m01;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public long m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public long m11;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public lmat2(long m00, long m01, long m10, long m11)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m10 = m10;
            this.m11 = m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat3x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lmat4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat2(lvec2 c0, lvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public long[,] Values => new[,] { { m00, m01 }, { m10, m11 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public long[] Values1D => new[] { m00, m01, m10, m11 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public lvec2 Column0
        {
            get
            {
                return new lvec2(m00, m01);
            }
            set
            {
                m00 = value.x;
                m01 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 1
        /// </summary>
        public lvec2 Column1
        {
            get
            {
                return new lvec2(m10, m11);
            }
            set
            {
                m10 = value.x;
                m11 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public lvec2 Row0
        {
            get
            {
                return new lvec2(m00, m10);
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
        public lvec2 Row1
        {
            get
            {
                return new lvec2(m01, m11);
            }
            set
            {
                m01 = value.x;
                m11 = value.y;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static lmat2 Zero { get; } = new lmat2(0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static lmat2 Ones { get; } = new lmat2(1, 1, 1, 1);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static lmat2 Identity { get; } = new lmat2(1, 0, 0, 1);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static lmat2 AllMaxValue { get; } = new lmat2(long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static lmat2 DiagonalMaxValue { get; } = new lmat2(long.MaxValue, 0, 0, long.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static lmat2 AllMinValue { get; } = new lmat2(long.MinValue, long.MinValue, long.MinValue, long.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static lmat2 DiagonalMinValue { get; } = new lmat2(long.MinValue, 0, 0, long.MinValue);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<long> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m10;
            yield return m11;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (2 x 2 = 4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public long this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m10;
                    case 3: return m11;
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
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public long this[int col, int row]
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
        public bool Equals(lmat2 rhs) => ((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m10.Equals(rhs.m10) && m11.Equals(rhs.m11)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is lmat2 && Equals((lmat2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(lmat2 lhs, lmat2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(lmat2 lhs, lmat2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public lmat2 Transposed => new lmat2(m00, m10, m01, m11);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public long MinElement => Math.Min(Math.Min(Math.Min(m00, m01), m10), m11);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public long MaxElement => Math.Max(Math.Max(Math.Max(m00, m01), m10), m11);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public double Length => (double)Math.Sqrt(((m00*m00 + m01*m01) + (m10*m10 + m11*m11)));
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public double LengthSqr => ((m00*m00 + m01*m01) + (m10*m10 + m11*m11));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public long Sum => ((m00 + m01) + (m10 + m11));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public double Norm => (double)Math.Sqrt(((m00*m00 + m01*m01) + (m10*m10 + m11*m11)));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public double Norm1 => ((Math.Abs(m00) + Math.Abs(m01)) + (Math.Abs(m10) + Math.Abs(m11)));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(((m00*m00 + m01*m01) + (m10*m10 + m11*m11)));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public long NormMax => Math.Max(Math.Max(Math.Max(Math.Abs(m00), Math.Abs(m01)), Math.Abs(m10)), Math.Abs(m11));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow(((Math.Pow((double)Math.Abs(m00), p) + Math.Pow((double)Math.Abs(m01), p)) + (Math.Pow((double)Math.Abs(m10), p) + Math.Pow((double)Math.Abs(m11), p))), 1 / p);
        
        /// <summary>
        /// Returns determinant of this matrix.
        /// </summary>
        public long Determinant => m00 * m11 - m10 * m01;
        
        /// <summary>
        /// Returns the adjunct of this matrix.
        /// </summary>
        public lmat2 Adjugate => new lmat2(m11, -m01, -m10, m00);
        
        /// <summary>
        /// Returns the inverse of this matrix (use with caution).
        /// </summary>
        public lmat2 Inverse => Adjugate / Determinant;
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat2 * lmat2 -> lmat2.
        /// </summary>
        public static lmat2 operator*(lmat2 lhs, lmat2 rhs) => new lmat2((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat2 * lmat3x2 -> lmat3x2.
        /// </summary>
        public static lmat3x2 operator*(lmat2 lhs, lmat3x2 rhs) => new lmat3x2((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat2 * lmat4x2 -> lmat4x2.
        /// </summary>
        public static lmat4x2 operator*(lmat2 lhs, lmat4x2 rhs) => new lmat4x2((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21), (lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31), (lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static lvec2 operator*(lmat2 m, lvec2 v) => new lvec2((m.m00 * v.x + m.m10 * v.y), (m.m01 * v.x + m.m11 * v.y));
        
        /// <summary>
        /// Executes a matrix-matrix-divison A / B == A * B^-1 (use with caution).
        /// </summary>
        public static lmat2 operator/(lmat2 A, lmat2 B) => A * B.Inverse;
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static lmat2 CompMul(lmat2 A, lmat2 B) => new lmat2(A.m00 * B.m00, A.m01 * B.m01, A.m10 * B.m10, A.m11 * B.m11);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static lmat2 CompDiv(lmat2 A, lmat2 B) => new lmat2(A.m00 / B.m00, A.m01 / B.m01, A.m10 / B.m10, A.m11 / B.m11);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static lmat2 CompAdd(lmat2 A, lmat2 B) => new lmat2(A.m00 + B.m00, A.m01 + B.m01, A.m10 + B.m10, A.m11 + B.m11);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static lmat2 CompSub(lmat2 A, lmat2 B) => new lmat2(A.m00 - B.m00, A.m01 - B.m01, A.m10 - B.m10, A.m11 - B.m11);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static lmat2 operator+(lmat2 lhs, lmat2 rhs) => new lmat2(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static lmat2 operator+(lmat2 lhs, long rhs) => new lmat2(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m10 + rhs, lhs.m11 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static lmat2 operator+(long lhs, lmat2 rhs) => new lmat2(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m10, lhs + rhs.m11);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static lmat2 operator-(lmat2 lhs, lmat2 rhs) => new lmat2(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static lmat2 operator-(lmat2 lhs, long rhs) => new lmat2(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m10 - rhs, lhs.m11 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static lmat2 operator-(long lhs, lmat2 rhs) => new lmat2(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m10, lhs - rhs.m11);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static lmat2 operator/(lmat2 lhs, long rhs) => new lmat2(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m10 / rhs, lhs.m11 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static lmat2 operator/(long lhs, lmat2 rhs) => new lmat2(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m10, lhs / rhs.m11);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static lmat2 operator*(lmat2 lhs, long rhs) => new lmat2(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m10 * rhs, lhs.m11 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static lmat2 operator*(long lhs, lmat2 rhs) => new lmat2(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m10, lhs * rhs.m11);
        
        /// <summary>
        /// Executes a component-wise % (modulo).
        /// </summary>
        public static lmat2 operator%(lmat2 lhs, lmat2 rhs) => new lmat2(lhs.m00 % rhs.m00, lhs.m01 % rhs.m01, lhs.m10 % rhs.m10, lhs.m11 % rhs.m11);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static lmat2 operator%(lmat2 lhs, long rhs) => new lmat2(lhs.m00 % rhs, lhs.m01 % rhs, lhs.m10 % rhs, lhs.m11 % rhs);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static lmat2 operator%(long lhs, lmat2 rhs) => new lmat2(lhs % rhs.m00, lhs % rhs.m01, lhs % rhs.m10, lhs % rhs.m11);
        
        /// <summary>
        /// Executes a component-wise ^ (xor).
        /// </summary>
        public static lmat2 operator^(lmat2 lhs, lmat2 rhs) => new lmat2(lhs.m00 ^ rhs.m00, lhs.m01 ^ rhs.m01, lhs.m10 ^ rhs.m10, lhs.m11 ^ rhs.m11);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static lmat2 operator^(lmat2 lhs, long rhs) => new lmat2(lhs.m00 ^ rhs, lhs.m01 ^ rhs, lhs.m10 ^ rhs, lhs.m11 ^ rhs);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static lmat2 operator^(long lhs, lmat2 rhs) => new lmat2(lhs ^ rhs.m00, lhs ^ rhs.m01, lhs ^ rhs.m10, lhs ^ rhs.m11);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or).
        /// </summary>
        public static lmat2 operator|(lmat2 lhs, lmat2 rhs) => new lmat2(lhs.m00 | rhs.m00, lhs.m01 | rhs.m01, lhs.m10 | rhs.m10, lhs.m11 | rhs.m11);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static lmat2 operator|(lmat2 lhs, long rhs) => new lmat2(lhs.m00 | rhs, lhs.m01 | rhs, lhs.m10 | rhs, lhs.m11 | rhs);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static lmat2 operator|(long lhs, lmat2 rhs) => new lmat2(lhs | rhs.m00, lhs | rhs.m01, lhs | rhs.m10, lhs | rhs.m11);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and).
        /// </summary>
        public static lmat2 operator&(lmat2 lhs, lmat2 rhs) => new lmat2(lhs.m00 & rhs.m00, lhs.m01 & rhs.m01, lhs.m10 & rhs.m10, lhs.m11 & rhs.m11);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and) with a scalar.
        /// </summary>
        public static lmat2 operator&(lmat2 lhs, long rhs) => new lmat2(lhs.m00 & rhs, lhs.m01 & rhs, lhs.m10 & rhs, lhs.m11 & rhs);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and) with a scalar.
        /// </summary>
        public static lmat2 operator&(long lhs, lmat2 rhs) => new lmat2(lhs & rhs.m00, lhs & rhs.m01, lhs & rhs.m10, lhs & rhs.m11);
        
        /// <summary>
        /// Executes a component-wise left-shift with a scalar.
        /// </summary>
        public static lmat2 operator<<(lmat2 lhs, int rhs) => new lmat2(lhs.m00 << rhs, lhs.m01 << rhs, lhs.m10 << rhs, lhs.m11 << rhs);
        
        /// <summary>
        /// Executes a component-wise right-shift with a scalar.
        /// </summary>
        public static lmat2 operator>>(lmat2 lhs, int rhs) => new lmat2(lhs.m00 >> rhs, lhs.m01 >> rhs, lhs.m10 >> rhs, lhs.m11 >> rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat2 operator<(lmat2 lhs, lmat2 rhs) => new bmat2(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat2 operator<(lmat2 lhs, long rhs) => new bmat2(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m10 < rhs, lhs.m11 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat2 operator<(long lhs, lmat2 rhs) => new bmat2(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m10, lhs < rhs.m11);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat2 operator<=(lmat2 lhs, lmat2 rhs) => new bmat2(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2 operator<=(lmat2 lhs, long rhs) => new bmat2(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2 operator<=(long lhs, lmat2 rhs) => new bmat2(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m10, lhs <= rhs.m11);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat2 operator>(lmat2 lhs, lmat2 rhs) => new bmat2(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat2 operator>(lmat2 lhs, long rhs) => new bmat2(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m10 > rhs, lhs.m11 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat2 operator>(long lhs, lmat2 rhs) => new bmat2(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m10, lhs > rhs.m11);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat2 operator>=(lmat2 lhs, lmat2 rhs) => new bmat2(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2 operator>=(lmat2 lhs, long rhs) => new bmat2(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2 operator>=(long lhs, lmat2 rhs) => new bmat2(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m10, lhs >= rhs.m11);
    }
}
