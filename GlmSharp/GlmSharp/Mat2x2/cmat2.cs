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
    /// A matrix of type Complex with 2 columns and 2 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct cmat2 : IReadOnlyList<Complex>, IEquatable<cmat2>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public Complex m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public Complex m01;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public Complex m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public Complex m11;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public cmat2(Complex m00, Complex m01, Complex m10, Complex m11)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m10 = m10;
            this.m11 = m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat3x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cmat4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat2(cvec2 c0, cvec2 c1)
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
        public Complex[,] Values => new[,] { { m00, m01 }, { m10, m11 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public Complex[] Values1D => new[] { m00, m01, m10, m11 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public cvec2 Column0
        {
            get
            {
                return new cvec2(m00, m01);
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
        public cvec2 Column1
        {
            get
            {
                return new cvec2(m10, m11);
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
        public cvec2 Row0
        {
            get
            {
                return new cvec2(m00, m10);
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
        public cvec2 Row1
        {
            get
            {
                return new cvec2(m01, m11);
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
        public static cmat2 Zero { get; } = new cmat2(Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static cmat2 Ones { get; } = new cmat2(Complex.One, Complex.One, Complex.One, Complex.One);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static cmat2 Identity { get; } = new cmat2(Complex.One, Complex.Zero, Complex.Zero, Complex.One);
        
        /// <summary>
        /// Predefined all-imaginary-ones matrix
        /// </summary>
        public static cmat2 ImaginaryOnes { get; } = new cmat2(Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne);
        
        /// <summary>
        /// Predefined diagonal-imaginary-one matrix
        /// </summary>
        public static cmat2 ImaginaryIdentity { get; } = new cmat2(Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.ImaginaryOne);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<Complex> GetEnumerator()
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
        public Complex this[int fieldIndex]
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
        public Complex this[int col, int row]
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
        public bool Equals(cmat2 rhs) => ((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m10.Equals(rhs.m10) && m11.Equals(rhs.m11)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is cmat2 && Equals((cmat2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(cmat2 lhs, cmat2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(cmat2 lhs, cmat2 rhs) => !lhs.Equals(rhs);
        
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
        public cmat2 Transposed => new cmat2(m00, m10, m01, m11);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public double Length => (double)Math.Sqrt(((m00.LengthSqr() + m01.LengthSqr()) + (m10.LengthSqr() + m11.LengthSqr())));
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public double LengthSqr => ((m00.LengthSqr() + m01.LengthSqr()) + (m10.LengthSqr() + m11.LengthSqr()));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public Complex Sum => ((m00 + m01) + (m10 + m11));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public double Norm => (double)Math.Sqrt(((m00.LengthSqr() + m01.LengthSqr()) + (m10.LengthSqr() + m11.LengthSqr())));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public double Norm1 => ((m00.Magnitude + m01.Magnitude) + (m10.Magnitude + m11.Magnitude));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(((m00.LengthSqr() + m01.LengthSqr()) + (m10.LengthSqr() + m11.LengthSqr())));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public Complex NormMax => Math.Max(Math.Max(Math.Max(m00.Magnitude, m01.Magnitude), m10.Magnitude), m11.Magnitude);
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow(((Math.Pow((double)m00.Magnitude, p) + Math.Pow((double)m01.Magnitude, p)) + (Math.Pow((double)m10.Magnitude, p) + Math.Pow((double)m11.Magnitude, p))), 1 / p);
        
        /// <summary>
        /// Returns determinant of this matrix.
        /// </summary>
        public Complex Determinant => m00 * m11 - m10 * m01;
        
        /// <summary>
        /// Returns the adjunct of this matrix.
        /// </summary>
        public cmat2 Adjugate => new cmat2(m11, -m01, -m10, m00);
        
        /// <summary>
        /// Returns the inverse of this matrix (use with caution).
        /// </summary>
        public cmat2 Inverse => Adjugate / Determinant;
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat2 * cmat2 -> cmat2.
        /// </summary>
        public static cmat2 operator*(cmat2 lhs, cmat2 rhs) => new cmat2((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat2 * cmat3x2 -> cmat3x2.
        /// </summary>
        public static cmat3x2 operator*(cmat2 lhs, cmat3x2 rhs) => new cmat3x2((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat2 * cmat4x2 -> cmat4x2.
        /// </summary>
        public static cmat4x2 operator*(cmat2 lhs, cmat4x2 rhs) => new cmat4x2((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21), (lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31), (lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static cvec2 operator*(cmat2 m, cvec2 v) => new cvec2((m.m00 * v.x + m.m10 * v.y), (m.m01 * v.x + m.m11 * v.y));
        
        /// <summary>
        /// Executes a matrix-matrix-divison A / B == A * B^-1 (use with caution).
        /// </summary>
        public static cmat2 operator/(cmat2 A, cmat2 B) => A * B.Inverse;
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static cmat2 CompMul(cmat2 A, cmat2 B) => new cmat2(A.m00 * B.m00, A.m01 * B.m01, A.m10 * B.m10, A.m11 * B.m11);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static cmat2 CompDiv(cmat2 A, cmat2 B) => new cmat2(A.m00 / B.m00, A.m01 / B.m01, A.m10 / B.m10, A.m11 / B.m11);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static cmat2 CompAdd(cmat2 A, cmat2 B) => new cmat2(A.m00 + B.m00, A.m01 + B.m01, A.m10 + B.m10, A.m11 + B.m11);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static cmat2 CompSub(cmat2 A, cmat2 B) => new cmat2(A.m00 - B.m00, A.m01 - B.m01, A.m10 - B.m10, A.m11 - B.m11);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static cmat2 operator+(cmat2 lhs, cmat2 rhs) => new cmat2(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cmat2 operator+(cmat2 lhs, Complex rhs) => new cmat2(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m10 + rhs, lhs.m11 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cmat2 operator+(Complex lhs, cmat2 rhs) => new cmat2(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m10, lhs + rhs.m11);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static cmat2 operator-(cmat2 lhs, cmat2 rhs) => new cmat2(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cmat2 operator-(cmat2 lhs, Complex rhs) => new cmat2(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m10 - rhs, lhs.m11 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cmat2 operator-(Complex lhs, cmat2 rhs) => new cmat2(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m10, lhs - rhs.m11);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static cmat2 operator/(cmat2 lhs, Complex rhs) => new cmat2(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m10 / rhs, lhs.m11 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static cmat2 operator/(Complex lhs, cmat2 rhs) => new cmat2(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m10, lhs / rhs.m11);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static cmat2 operator*(cmat2 lhs, Complex rhs) => new cmat2(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m10 * rhs, lhs.m11 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static cmat2 operator*(Complex lhs, cmat2 rhs) => new cmat2(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m10, lhs * rhs.m11);
    }
}
