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
    /// A matrix of type Half with 2 columns and 4 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct hmat2x4 : IReadOnlyList<Half>, IEquatable<hmat2x4>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public Half m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public Half m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public Half m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public Half m03;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public Half m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public Half m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public Half m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public Half m13;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public hmat2x4(Half m00, Half m01, Half m02, Half m03, Half m10, Half m11, Half m12, Half m13)
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
        /// Constructs this matrix from a hmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Half.Zero;
            this.m03 = Half.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Half.Zero;
            this.m13 = Half.Zero;
        }
        
        /// <summary>
        /// Constructs this matrix from a hmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Half.Zero;
            this.m03 = Half.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Half.Zero;
            this.m13 = Half.Zero;
        }
        
        /// <summary>
        /// Constructs this matrix from a hmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Half.Zero;
            this.m03 = Half.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Half.Zero;
            this.m13 = Half.Zero;
        }
        
        /// <summary>
        /// Constructs this matrix from a hmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = Half.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = Half.Zero;
        }
        
        /// <summary>
        /// Constructs this matrix from a hmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = Half.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = Half.Zero;
        }
        
        /// <summary>
        /// Constructs this matrix from a hmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = Half.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = Half.Zero;
        }
        
        /// <summary>
        /// Constructs this matrix from a hmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat2x4 m)
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
        /// Constructs this matrix from a hmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat3x4 m)
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
        /// Constructs this matrix from a hmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hmat4 m)
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
        public hmat2x4(hvec2 c0, hvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = Half.Zero;
            this.m03 = Half.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = Half.Zero;
            this.m13 = Half.Zero;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hvec3 c0, hvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = Half.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = Half.Zero;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public hmat2x4(hvec4 c0, hvec4 c1)
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
        public Half[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public Half[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public hvec4 Column0
        {
            get
            {
                return new hvec4(m00, m01, m02, m03);
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
        public hvec4 Column1
        {
            get
            {
                return new hvec4(m10, m11, m12, m13);
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
        public hvec2 Row0
        {
            get
            {
                return new hvec2(m00, m10);
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
        public hvec2 Row1
        {
            get
            {
                return new hvec2(m01, m11);
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
        public hvec2 Row2
        {
            get
            {
                return new hvec2(m02, m12);
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
        public hvec2 Row3
        {
            get
            {
                return new hvec2(m03, m13);
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
        public static hmat2x4 Zero { get; } = new hmat2x4(Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static hmat2x4 Ones { get; } = new hmat2x4(Half.One, Half.One, Half.One, Half.One, Half.One, Half.One, Half.One, Half.One);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static hmat2x4 Identity { get; } = new hmat2x4(Half.One, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.One, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static hmat2x4 AllMaxValue { get; } = new hmat2x4(Half.MaxValue, Half.MaxValue, Half.MaxValue, Half.MaxValue, Half.MaxValue, Half.MaxValue, Half.MaxValue, Half.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static hmat2x4 DiagonalMaxValue { get; } = new hmat2x4(Half.MaxValue, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.MaxValue, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static hmat2x4 AllMinValue { get; } = new hmat2x4(Half.MinValue, Half.MinValue, Half.MinValue, Half.MinValue, Half.MinValue, Half.MinValue, Half.MinValue, Half.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static hmat2x4 DiagonalMinValue { get; } = new hmat2x4(Half.MinValue, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.MinValue, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-Epsilon matrix
        /// </summary>
        public static hmat2x4 AllEpsilon { get; } = new hmat2x4(Half.Epsilon, Half.Epsilon, Half.Epsilon, Half.Epsilon, Half.Epsilon, Half.Epsilon, Half.Epsilon, Half.Epsilon);
        
        /// <summary>
        /// Predefined diagonal-Epsilon matrix
        /// </summary>
        public static hmat2x4 DiagonalEpsilon { get; } = new hmat2x4(Half.Epsilon, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.Epsilon, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-NaN matrix
        /// </summary>
        public static hmat2x4 AllNaN { get; } = new hmat2x4(Half.NaN, Half.NaN, Half.NaN, Half.NaN, Half.NaN, Half.NaN, Half.NaN, Half.NaN);
        
        /// <summary>
        /// Predefined diagonal-NaN matrix
        /// </summary>
        public static hmat2x4 DiagonalNaN { get; } = new hmat2x4(Half.NaN, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.NaN, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-NegativeInfinity matrix
        /// </summary>
        public static hmat2x4 AllNegativeInfinity { get; } = new hmat2x4(Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity);
        
        /// <summary>
        /// Predefined diagonal-NegativeInfinity matrix
        /// </summary>
        public static hmat2x4 DiagonalNegativeInfinity { get; } = new hmat2x4(Half.NegativeInfinity, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.NegativeInfinity, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-PositiveInfinity matrix
        /// </summary>
        public static hmat2x4 AllPositiveInfinity { get; } = new hmat2x4(Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity);
        
        /// <summary>
        /// Predefined diagonal-PositiveInfinity matrix
        /// </summary>
        public static hmat2x4 DiagonalPositiveInfinity { get; } = new hmat2x4(Half.PositiveInfinity, Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.PositiveInfinity, Half.Zero, Half.Zero);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<Half> GetEnumerator()
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
        public Half this[int fieldIndex]
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
        public Half this[int col, int row]
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
        public bool Equals(hmat2x4 rhs) => (((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m02.Equals(rhs.m02) && m03.Equals(rhs.m03))) && ((m10.Equals(rhs.m10) && m11.Equals(rhs.m11)) && (m12.Equals(rhs.m12) && m13.Equals(rhs.m13))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is hmat2x4 && Equals((hmat2x4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(hmat2x4 lhs, hmat2x4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(hmat2x4 lhs, hmat2x4 rhs) => !lhs.Equals(rhs);
        
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
        public hmat4x2 Transposed => new hmat4x2(m00, m10, m01, m11, m02, m12, m03, m13);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public Half MinElement => Half.Min(Half.Min(Half.Min(Half.Min(Half.Min(Half.Min(Half.Min(m00, m01), m02), m03), m10), m11), m12), m13);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public Half MaxElement => Half.Max(Half.Max(Half.Max(Half.Max(Half.Max(Half.Max(Half.Max(m00, m01), m02), m03), m10), m11), m12), m13);
        
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
        public Half Sum => (((m00 + m01) + (m02 + m03)) + ((m10 + m11) + (m12 + m13)));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public float Norm => (float)Math.Sqrt((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public float Norm1 => (((Half.Abs(m00) + Half.Abs(m01)) + (Half.Abs(m02) + Half.Abs(m03))) + ((Half.Abs(m10) + Half.Abs(m11)) + (Half.Abs(m12) + Half.Abs(m13))));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public Half NormMax => Half.Max(Half.Max(Half.Max(Half.Max(Half.Max(Half.Max(Half.Max(Half.Abs(m00), Half.Abs(m01)), Half.Abs(m02)), Half.Abs(m03)), Half.Abs(m10)), Half.Abs(m11)), Half.Abs(m12)), Half.Abs(m13));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow((((Math.Pow((double)Half.Abs(m00), p) + Math.Pow((double)Half.Abs(m01), p)) + (Math.Pow((double)Half.Abs(m02), p) + Math.Pow((double)Half.Abs(m03), p))) + ((Math.Pow((double)Half.Abs(m10), p) + Math.Pow((double)Half.Abs(m11), p)) + (Math.Pow((double)Half.Abs(m12), p) + Math.Pow((double)Half.Abs(m13), p)))), 1 / p);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication hmat2x4 * hmat2 -> hmat2x4.
        /// </summary>
        public static hmat2x4 operator*(hmat2x4 lhs, hmat2 rhs) => new hmat2x4((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11), (lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication hmat2x4 * hmat3x2 -> hmat3x4.
        /// </summary>
        public static hmat3x4 operator*(hmat2x4 lhs, hmat3x2 rhs) => new hmat3x4((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11), (lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21), (lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21), (lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication hmat2x4 * hmat4x2 -> hmat4.
        /// </summary>
        public static hmat4 operator*(hmat2x4 lhs, hmat4x2 rhs) => new hmat4((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01), (lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01), (lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01), (lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01), (lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11), (lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11), (lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11), (lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11), (lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21), (lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21), (lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21), (lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21), (lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31), (lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31), (lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31), (lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static hvec4 operator*(hmat2x4 m, hvec2 v) => new hvec4((m.m00 * v.x + m.m10 * v.y), (m.m01 * v.x + m.m11 * v.y), (m.m02 * v.x + m.m12 * v.y), (m.m03 * v.x + m.m13 * v.y));
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static hmat2x4 CompMul(hmat2x4 A, hmat2x4 B) => new hmat2x4(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m03 * B.m03, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12, A.m13 * B.m13);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static hmat2x4 CompDiv(hmat2x4 A, hmat2x4 B) => new hmat2x4(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m03 / B.m03, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12, A.m13 / B.m13);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static hmat2x4 CompAdd(hmat2x4 A, hmat2x4 B) => new hmat2x4(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m03 + B.m03, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12, A.m13 + B.m13);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static hmat2x4 CompSub(hmat2x4 A, hmat2x4 B) => new hmat2x4(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m03 - B.m03, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12, A.m13 - B.m13);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static hmat2x4 operator+(hmat2x4 lhs, hmat2x4 rhs) => new hmat2x4(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m03 + rhs.m03, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static hmat2x4 operator+(hmat2x4 lhs, Half rhs) => new hmat2x4(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m03 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m13 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static hmat2x4 operator+(Half lhs, hmat2x4 rhs) => new hmat2x4(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m03, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m13);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static hmat2x4 operator-(hmat2x4 lhs, hmat2x4 rhs) => new hmat2x4(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m03 - rhs.m03, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static hmat2x4 operator-(hmat2x4 lhs, Half rhs) => new hmat2x4(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m03 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m13 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static hmat2x4 operator-(Half lhs, hmat2x4 rhs) => new hmat2x4(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m03, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m13);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static hmat2x4 operator/(hmat2x4 lhs, Half rhs) => new hmat2x4(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m03 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs, lhs.m13 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static hmat2x4 operator/(Half lhs, hmat2x4 rhs) => new hmat2x4(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m03, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12, lhs / rhs.m13);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static hmat2x4 operator*(hmat2x4 lhs, Half rhs) => new hmat2x4(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m03 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs, lhs.m13 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static hmat2x4 operator*(Half lhs, hmat2x4 rhs) => new hmat2x4(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m03, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12, lhs * rhs.m13);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat2x4 operator<(hmat2x4 lhs, hmat2x4 rhs) => new bmat2x4(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m02 < rhs.m02, lhs.m03 < rhs.m03, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11, lhs.m12 < rhs.m12, lhs.m13 < rhs.m13);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator<(hmat2x4 lhs, Half rhs) => new bmat2x4(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m02 < rhs, lhs.m03 < rhs, lhs.m10 < rhs, lhs.m11 < rhs, lhs.m12 < rhs, lhs.m13 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator<(Half lhs, hmat2x4 rhs) => new bmat2x4(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m02, lhs < rhs.m03, lhs < rhs.m10, lhs < rhs.m11, lhs < rhs.m12, lhs < rhs.m13);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat2x4 operator<=(hmat2x4 lhs, hmat2x4 rhs) => new bmat2x4(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m02 <= rhs.m02, lhs.m03 <= rhs.m03, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11, lhs.m12 <= rhs.m12, lhs.m13 <= rhs.m13);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator<=(hmat2x4 lhs, Half rhs) => new bmat2x4(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m02 <= rhs, lhs.m03 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs, lhs.m12 <= rhs, lhs.m13 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator<=(Half lhs, hmat2x4 rhs) => new bmat2x4(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m02, lhs <= rhs.m03, lhs <= rhs.m10, lhs <= rhs.m11, lhs <= rhs.m12, lhs <= rhs.m13);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat2x4 operator>(hmat2x4 lhs, hmat2x4 rhs) => new bmat2x4(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m02 > rhs.m02, lhs.m03 > rhs.m03, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11, lhs.m12 > rhs.m12, lhs.m13 > rhs.m13);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator>(hmat2x4 lhs, Half rhs) => new bmat2x4(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m02 > rhs, lhs.m03 > rhs, lhs.m10 > rhs, lhs.m11 > rhs, lhs.m12 > rhs, lhs.m13 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator>(Half lhs, hmat2x4 rhs) => new bmat2x4(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m02, lhs > rhs.m03, lhs > rhs.m10, lhs > rhs.m11, lhs > rhs.m12, lhs > rhs.m13);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat2x4 operator>=(hmat2x4 lhs, hmat2x4 rhs) => new bmat2x4(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m02 >= rhs.m02, lhs.m03 >= rhs.m03, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11, lhs.m12 >= rhs.m12, lhs.m13 >= rhs.m13);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator>=(hmat2x4 lhs, Half rhs) => new bmat2x4(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m02 >= rhs, lhs.m03 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs, lhs.m12 >= rhs, lhs.m13 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat2x4 operator>=(Half lhs, hmat2x4 rhs) => new bmat2x4(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m02, lhs >= rhs.m03, lhs >= rhs.m10, lhs >= rhs.m11, lhs >= rhs.m12, lhs >= rhs.m13);
    }
}
