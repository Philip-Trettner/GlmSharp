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
    /// A matrix of type Complex with 3 columns and 3 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct cmat3 : IReadOnlyList<Complex>, IEquatable<cmat3>
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
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public Complex m02;
        
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
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public Complex m12;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public Complex m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public Complex m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public Complex m22;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public cmat3(Complex m00, Complex m01, Complex m02, Complex m10, Complex m11, Complex m12, Complex m20, Complex m21, Complex m22)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Complex.Zero;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat3 m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat4x3 m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat3x4 m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cmat4 m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cvec2 c0, cvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = Complex.Zero;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cvec2 c0, cvec2 c1, cvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cvec3 c0, cvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat3(cvec3 c0, cvec3 c1, cvec3 c2)
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
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public Complex[,] Values => new[,] { { m00, m01, m02 }, { m10, m11, m12 }, { m20, m21, m22 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public Complex[] Values1D => new[] { m00, m01, m02, m10, m11, m12, m20, m21, m22 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public cvec3 Column0
        {
            get
            {
                return new cvec3(m00, m01, m02);
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
        public cvec3 Column1
        {
            get
            {
                return new cvec3(m10, m11, m12);
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
        public cvec3 Column2
        {
            get
            {
                return new cvec3(m20, m21, m22);
            }
            set
            {
                m20 = value.x;
                m21 = value.y;
                m22 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public cvec3 Row0
        {
            get
            {
                return new cvec3(m00, m10, m20);
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
        public cvec3 Row1
        {
            get
            {
                return new cvec3(m01, m11, m21);
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
        public cvec3 Row2
        {
            get
            {
                return new cvec3(m02, m12, m22);
            }
            set
            {
                m02 = value.x;
                m12 = value.y;
                m22 = value.z;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static cmat3 Zero { get; } = new cmat3(Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static cmat3 Ones { get; } = new cmat3(Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static cmat3 Identity { get; } = new cmat3(Complex.One, Complex.Zero, Complex.Zero, Complex.Zero, Complex.One, Complex.Zero, Complex.Zero, Complex.Zero, Complex.One);
        
        /// <summary>
        /// Predefined all-imaginary-ones matrix
        /// </summary>
        public static cmat3 ImaginaryOnes { get; } = new cmat3(Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne);
        
        /// <summary>
        /// Predefined diagonal-imaginary-one matrix
        /// </summary>
        public static cmat3 ImaginaryIdentity { get; } = new cmat3(Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<Complex> GetEnumerator()
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
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (3 x 3 = 9).
        /// </summary>
        public int Count => 9;
        
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
                    case 2: return m02;
                    case 3: return m10;
                    case 4: return m11;
                    case 5: return m12;
                    case 6: return m20;
                    case 7: return m21;
                    case 8: return m22;
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
        public bool Equals(cmat3 rhs) => ((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && m02.Equals(rhs.m02)) && (m10.Equals(rhs.m10) && m11.Equals(rhs.m11))) && ((m12.Equals(rhs.m12) && m20.Equals(rhs.m20)) && (m21.Equals(rhs.m21) && m22.Equals(rhs.m22))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is cmat3 && Equals((cmat3) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(cmat3 lhs, cmat3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(cmat3 lhs, cmat3 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m22.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public cmat3 Transposed => new cmat3(m00, m10, m20, m01, m11, m21, m02, m12, m22);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public double Length => (double)Math.Sqrt(((((m00.LengthSqr() + m01.LengthSqr()) + m02.LengthSqr()) + (m10.LengthSqr() + m11.LengthSqr())) + ((m12.LengthSqr() + m20.LengthSqr()) + (m21.LengthSqr() + m22.LengthSqr()))));
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public double LengthSqr => ((((m00.LengthSqr() + m01.LengthSqr()) + m02.LengthSqr()) + (m10.LengthSqr() + m11.LengthSqr())) + ((m12.LengthSqr() + m20.LengthSqr()) + (m21.LengthSqr() + m22.LengthSqr())));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public Complex Sum => ((((m00 + m01) + m02) + (m10 + m11)) + ((m12 + m20) + (m21 + m22)));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public double Norm => (double)Math.Sqrt(((((m00.LengthSqr() + m01.LengthSqr()) + m02.LengthSqr()) + (m10.LengthSqr() + m11.LengthSqr())) + ((m12.LengthSqr() + m20.LengthSqr()) + (m21.LengthSqr() + m22.LengthSqr()))));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public double Norm1 => ((((m00.Magnitude + m01.Magnitude) + m02.Magnitude) + (m10.Magnitude + m11.Magnitude)) + ((m12.Magnitude + m20.Magnitude) + (m21.Magnitude + m22.Magnitude)));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(((((m00.LengthSqr() + m01.LengthSqr()) + m02.LengthSqr()) + (m10.LengthSqr() + m11.LengthSqr())) + ((m12.LengthSqr() + m20.LengthSqr()) + (m21.LengthSqr() + m22.LengthSqr()))));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public Complex NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00.Magnitude, m01.Magnitude), m02.Magnitude), m10.Magnitude), m11.Magnitude), m12.Magnitude), m20.Magnitude), m21.Magnitude), m22.Magnitude);
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow(((((Math.Pow((double)m00.Magnitude, p) + Math.Pow((double)m01.Magnitude, p)) + Math.Pow((double)m02.Magnitude, p)) + (Math.Pow((double)m10.Magnitude, p) + Math.Pow((double)m11.Magnitude, p))) + ((Math.Pow((double)m12.Magnitude, p) + Math.Pow((double)m20.Magnitude, p)) + (Math.Pow((double)m21.Magnitude, p) + Math.Pow((double)m22.Magnitude, p)))), 1 / p);
        
        /// <summary>
        /// Returns determinant of this matrix.
        /// </summary>
        public Complex Determinant => m00 * (m11 * m22 - m21 * m12) - m10 * (m01 * m22 - m21 * m02) + m20 * (m01 * m12 - m11 * m02);
        
        /// <summary>
        /// Returns the adjunct of this matrix.
        /// </summary>
        public cmat3 Adjugate => new cmat3(m11 * m22 - m21 * m12, -m01 * m22 + m21 * m02, m01 * m12 - m11 * m02, -m10 * m22 + m20 * m12, m00 * m22 - m20 * m02, -m00 * m12 + m10 * m02, m10 * m21 - m20 * m11, -m00 * m21 + m20 * m01, m00 * m11 - m10 * m01);
        
        /// <summary>
        /// Returns the inverse of this matrix (use with caution).
        /// </summary>
        public cmat3 Inverse => Adjugate / Determinant;
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat3 * cmat2x3 -> cmat2x3.
        /// </summary>
        public static cmat2x3 operator*(cmat3 lhs, cmat2x3 rhs) => new cmat2x3(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat3 * cmat3 -> cmat3.
        /// </summary>
        public static cmat3 operator*(cmat3 lhs, cmat3 rhs) => new cmat3(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12), ((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22), ((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22), ((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat3 * cmat4x3 -> cmat4x3.
        /// </summary>
        public static cmat4x3 operator*(cmat3 lhs, cmat4x3 rhs) => new cmat4x3(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12), ((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22), ((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22), ((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22), ((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + lhs.m20 * rhs.m32), ((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + lhs.m21 * rhs.m32), ((lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31) + lhs.m22 * rhs.m32));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static cvec3 operator*(cmat3 m, cvec3 v) => new cvec3(((m.m00 * v.x + m.m10 * v.y) + m.m20 * v.z), ((m.m01 * v.x + m.m11 * v.y) + m.m21 * v.z), ((m.m02 * v.x + m.m12 * v.y) + m.m22 * v.z));
        
        /// <summary>
        /// Executes a matrix-matrix-divison A / B == A * B^-1 (use with caution).
        /// </summary>
        public static cmat3 operator/(cmat3 A, cmat3 B) => A * B.Inverse;
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static cmat3 CompMul(cmat3 A, cmat3 B) => new cmat3(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12, A.m20 * B.m20, A.m21 * B.m21, A.m22 * B.m22);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static cmat3 CompDiv(cmat3 A, cmat3 B) => new cmat3(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12, A.m20 / B.m20, A.m21 / B.m21, A.m22 / B.m22);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static cmat3 CompAdd(cmat3 A, cmat3 B) => new cmat3(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12, A.m20 + B.m20, A.m21 + B.m21, A.m22 + B.m22);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static cmat3 CompSub(cmat3 A, cmat3 B) => new cmat3(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12, A.m20 - B.m20, A.m21 - B.m21, A.m22 - B.m22);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static cmat3 operator+(cmat3 lhs, cmat3 rhs) => new cmat3(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m20 + rhs.m20, lhs.m21 + rhs.m21, lhs.m22 + rhs.m22);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cmat3 operator+(cmat3 lhs, Complex rhs) => new cmat3(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m20 + rhs, lhs.m21 + rhs, lhs.m22 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cmat3 operator+(Complex lhs, cmat3 rhs) => new cmat3(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m20, lhs + rhs.m21, lhs + rhs.m22);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static cmat3 operator-(cmat3 lhs, cmat3 rhs) => new cmat3(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m20 - rhs.m20, lhs.m21 - rhs.m21, lhs.m22 - rhs.m22);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cmat3 operator-(cmat3 lhs, Complex rhs) => new cmat3(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m20 - rhs, lhs.m21 - rhs, lhs.m22 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cmat3 operator-(Complex lhs, cmat3 rhs) => new cmat3(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m20, lhs - rhs.m21, lhs - rhs.m22);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static cmat3 operator/(cmat3 lhs, Complex rhs) => new cmat3(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs, lhs.m20 / rhs, lhs.m21 / rhs, lhs.m22 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static cmat3 operator/(Complex lhs, cmat3 rhs) => new cmat3(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12, lhs / rhs.m20, lhs / rhs.m21, lhs / rhs.m22);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static cmat3 operator*(cmat3 lhs, Complex rhs) => new cmat3(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs, lhs.m20 * rhs, lhs.m21 * rhs, lhs.m22 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static cmat3 operator*(Complex lhs, cmat3 rhs) => new cmat3(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12, lhs * rhs.m20, lhs * rhs.m21, lhs * rhs.m22);
    }
}
