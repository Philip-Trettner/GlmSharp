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
    /// A matrix of type decimal with 2 columns and 3 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct decmat2x3 : IReadOnlyList<decimal>, IEquatable<decmat2x3>
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decmat2x3(decimal m00, decimal m01, decimal m02, decimal m10, decimal m11, decimal m12)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat3x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decmat4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decvec2 c0, decvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0m;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat2x3(decvec3 c0, decvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public decimal[,] Values => new[,] { { m00, m01, m02 }, { m10, m11, m12 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public decimal[] Values1D => new[] { m00, m01, m02, m10, m11, m12 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public decvec3 Column0
        {
            get
            {
                return new decvec3(m00, m01, m02);
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
        public decvec3 Column1
        {
            get
            {
                return new decvec3(m10, m11, m12);
            }
            set
            {
                m10 = value.x;
                m11 = value.y;
                m12 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public decvec2 Row0
        {
            get
            {
                return new decvec2(m00, m10);
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
        public decvec2 Row1
        {
            get
            {
                return new decvec2(m01, m11);
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
        public decvec2 Row2
        {
            get
            {
                return new decvec2(m02, m12);
            }
            set
            {
                m02 = value.x;
                m12 = value.y;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static decmat2x3 Zero { get; } = new decmat2x3(0m, 0m, 0m, 0m, 0m, 0m);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static decmat2x3 Ones { get; } = new decmat2x3(1m, 1m, 1m, 1m, 1m, 1m);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static decmat2x3 Identity { get; } = new decmat2x3(1m, 0m, 0m, 0m, 1m, 0m);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static decmat2x3 AllMaxValue { get; } = new decmat2x3(decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static decmat2x3 DiagonalMaxValue { get; } = new decmat2x3(decimal.MaxValue, 0m, 0m, 0m, decimal.MaxValue, 0m);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static decmat2x3 AllMinValue { get; } = new decmat2x3(decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static decmat2x3 DiagonalMinValue { get; } = new decmat2x3(decimal.MinValue, 0m, 0m, 0m, decimal.MinValue, 0m);
        
        /// <summary>
        /// Predefined all-MinusOne matrix
        /// </summary>
        public static decmat2x3 AllMinusOne { get; } = new decmat2x3(decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne);
        
        /// <summary>
        /// Predefined diagonal-MinusOne matrix
        /// </summary>
        public static decmat2x3 DiagonalMinusOne { get; } = new decmat2x3(decimal.MinusOne, 0m, 0m, 0m, decimal.MinusOne, 0m);

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
            yield return m10;
            yield return m11;
            yield return m12;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (2 x 3 = 6).
        /// </summary>
        public int Count => 6;
        
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
                    case 3: return m10;
                    case 4: return m11;
                    case 5: return m12;
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
        public bool Equals(decmat2x3 rhs) => (((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && m02.Equals(rhs.m02)) && ((m10.Equals(rhs.m10) && m11.Equals(rhs.m11)) && m12.Equals(rhs.m12)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decmat2x3 && Equals((decmat2x3) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(decmat2x3 lhs, decmat2x3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(decmat2x3 lhs, decmat2x3 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public decmat3x2 Transposed => new decmat3x2(m00, m10, m01, m11, m02, m12);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public decimal MinElement => Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(m00, m01), m02), m10), m11), m12);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public decimal MaxElement => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00, m01), m02), m10), m11), m12);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public decimal Length => (decimal)((((m00*m00 + m01*m01) + m02*m02) + ((m10*m10 + m11*m11) + m12*m12))).Sqrt();
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public decimal LengthSqr => (((m00*m00 + m01*m01) + m02*m02) + ((m10*m10 + m11*m11) + m12*m12));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public decimal Sum => (((m00 + m01) + m02) + ((m10 + m11) + m12));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public decimal Norm => (decimal)((((m00*m00 + m01*m01) + m02*m02) + ((m10*m10 + m11*m11) + m12*m12))).Sqrt();
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public decimal Norm1 => (((Math.Abs(m00) + Math.Abs(m01)) + Math.Abs(m02)) + ((Math.Abs(m10) + Math.Abs(m11)) + Math.Abs(m12)));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public decimal Norm2 => (decimal)((((m00*m00 + m01*m01) + m02*m02) + ((m10*m10 + m11*m11) + m12*m12))).Sqrt();
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public decimal NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(m00), Math.Abs(m01)), Math.Abs(m02)), Math.Abs(m10)), Math.Abs(m11)), Math.Abs(m12));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow((((Math.Pow((double)Math.Abs(m00), p) + Math.Pow((double)Math.Abs(m01), p)) + Math.Pow((double)Math.Abs(m02), p)) + ((Math.Pow((double)Math.Abs(m10), p) + Math.Pow((double)Math.Abs(m11), p)) + Math.Pow((double)Math.Abs(m12), p))), 1 / p);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication decmat2x3 * decmat2 -> decmat2x3.
        /// </summary>
        public static decmat2x3 operator*(decmat2x3 lhs, decmat2 rhs) => new decmat2x3((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication decmat2x3 * decmat3x2 -> decmat3.
        /// </summary>
        public static decmat3 operator*(decmat2x3 lhs, decmat3x2 rhs) => new decmat3((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21), (lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication decmat2x3 * decmat4x2 -> decmat4x3.
        /// </summary>
        public static decmat4x3 operator*(decmat2x3 lhs, decmat4x2 rhs) => new decmat4x3((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21), (lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21), (lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31), (lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31), (lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static decvec3 operator*(decmat2x3 m, decvec2 v) => new decvec3((m.m00 * v.x + m.m10 * v.y), (m.m01 * v.x + m.m11 * v.y), (m.m02 * v.x + m.m12 * v.y));
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static decmat2x3 CompMul(decmat2x3 A, decmat2x3 B) => new decmat2x3(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static decmat2x3 CompDiv(decmat2x3 A, decmat2x3 B) => new decmat2x3(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static decmat2x3 CompAdd(decmat2x3 A, decmat2x3 B) => new decmat2x3(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static decmat2x3 CompSub(decmat2x3 A, decmat2x3 B) => new decmat2x3(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static decmat2x3 operator+(decmat2x3 lhs, decmat2x3 rhs) => new decmat2x3(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static decmat2x3 operator+(decmat2x3 lhs, decimal rhs) => new decmat2x3(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static decmat2x3 operator+(decimal lhs, decmat2x3 rhs) => new decmat2x3(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static decmat2x3 operator-(decmat2x3 lhs, decmat2x3 rhs) => new decmat2x3(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static decmat2x3 operator-(decmat2x3 lhs, decimal rhs) => new decmat2x3(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static decmat2x3 operator-(decimal lhs, decmat2x3 rhs) => new decmat2x3(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static decmat2x3 operator/(decmat2x3 lhs, decimal rhs) => new decmat2x3(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static decmat2x3 operator/(decimal lhs, decmat2x3 rhs) => new decmat2x3(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static decmat2x3 operator*(decmat2x3 lhs, decimal rhs) => new decmat2x3(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static decmat2x3 operator*(decimal lhs, decmat2x3 rhs) => new decmat2x3(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat2x3 operator<(decmat2x3 lhs, decmat2x3 rhs) => new bmat2x3(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m02 < rhs.m02, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11, lhs.m12 < rhs.m12);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat2x3 operator<(decmat2x3 lhs, decimal rhs) => new bmat2x3(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m02 < rhs, lhs.m10 < rhs, lhs.m11 < rhs, lhs.m12 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat2x3 operator<(decimal lhs, decmat2x3 rhs) => new bmat2x3(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m02, lhs < rhs.m10, lhs < rhs.m11, lhs < rhs.m12);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat2x3 operator<=(decmat2x3 lhs, decmat2x3 rhs) => new bmat2x3(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m02 <= rhs.m02, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11, lhs.m12 <= rhs.m12);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x3 operator<=(decmat2x3 lhs, decimal rhs) => new bmat2x3(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m02 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs, lhs.m12 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x3 operator<=(decimal lhs, decmat2x3 rhs) => new bmat2x3(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m02, lhs <= rhs.m10, lhs <= rhs.m11, lhs <= rhs.m12);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat2x3 operator>(decmat2x3 lhs, decmat2x3 rhs) => new bmat2x3(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m02 > rhs.m02, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11, lhs.m12 > rhs.m12);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat2x3 operator>(decmat2x3 lhs, decimal rhs) => new bmat2x3(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m02 > rhs, lhs.m10 > rhs, lhs.m11 > rhs, lhs.m12 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat2x3 operator>(decimal lhs, decmat2x3 rhs) => new bmat2x3(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m02, lhs > rhs.m10, lhs > rhs.m11, lhs > rhs.m12);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat2x3 operator>=(decmat2x3 lhs, decmat2x3 rhs) => new bmat2x3(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m02 >= rhs.m02, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11, lhs.m12 >= rhs.m12);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x3 operator>=(decmat2x3 lhs, decimal rhs) => new bmat2x3(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m02 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs, lhs.m12 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x3 operator>=(decimal lhs, decmat2x3 rhs) => new bmat2x3(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m02, lhs >= rhs.m10, lhs >= rhs.m11, lhs >= rhs.m12);
    }
}
