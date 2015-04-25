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
    /// A matrix of type bool with 4 columns and 4 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct bmat4 : IReadOnlyList<bool>, IEquatable<bmat4>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public bool m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public bool m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public bool m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public bool m03;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public bool m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public bool m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public bool m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public bool m13;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public bool m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public bool m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public bool m22;
        
        /// <summary>
        /// Column 2, Rows 3
        /// </summary>
        [DataMember]
        public bool m23;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        [DataMember]
        public bool m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        [DataMember]
        public bool m31;
        
        /// <summary>
        /// Column 3, Rows 2
        /// </summary>
        [DataMember]
        public bool m32;
        
        /// <summary>
        /// Column 3, Rows 3
        /// </summary>
        [DataMember]
        public bool m33;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bmat4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33)
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
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = false;
            this.m03 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = false;
            this.m13 = false;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = false;
            this.m03 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = false;
            this.m13 = false;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = true;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = false;
            this.m03 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = false;
            this.m13 = false;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = true;
            this.m23 = false;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = false;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = false;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = false;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = false;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat3x4 m)
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
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bmat4 m)
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
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec2 c0, bvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = false;
            this.m03 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = false;
            this.m13 = false;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec2 c0, bvec2 c1, bvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = false;
            this.m03 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = false;
            this.m13 = false;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = true;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec2 c0, bvec2 c1, bvec2 c2, bvec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = false;
            this.m03 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = false;
            this.m13 = false;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = true;
            this.m23 = false;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec3 c0, bvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = false;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec3 c0, bvec3 c1, bvec3 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = false;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec3 c0, bvec3 c1, bvec3 c2, bvec3 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = false;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = false;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec4 c0, bvec4 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m23 = false;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec4 c0, bvec4 c1, bvec4 c2)
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
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m33 = true;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat4(bvec4 c0, bvec4 c1, bvec4 c2, bvec4 c3)
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
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public bool[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 }, { m20, m21, m22, m23 }, { m30, m31, m32, m33 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public bool[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public bvec4 Column0
        {
            get
            {
                return new bvec4(m00, m01, m02, m03);
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
        public bvec4 Column1
        {
            get
            {
                return new bvec4(m10, m11, m12, m13);
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
        public bvec4 Column2
        {
            get
            {
                return new bvec4(m20, m21, m22, m23);
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
        /// Gets or sets the column nr 3
        /// </summary>
        public bvec4 Column3
        {
            get
            {
                return new bvec4(m30, m31, m32, m33);
            }
            set
            {
                m30 = value.x;
                m31 = value.y;
                m32 = value.z;
                m33 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public bvec4 Row0
        {
            get
            {
                return new bvec4(m00, m10, m20, m30);
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
        public bvec4 Row1
        {
            get
            {
                return new bvec4(m01, m11, m21, m31);
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
        public bvec4 Row2
        {
            get
            {
                return new bvec4(m02, m12, m22, m32);
            }
            set
            {
                m02 = value.x;
                m12 = value.y;
                m22 = value.z;
                m32 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 3
        /// </summary>
        public bvec4 Row3
        {
            get
            {
                return new bvec4(m03, m13, m23, m33);
            }
            set
            {
                m03 = value.x;
                m13 = value.y;
                m23 = value.z;
                m33 = value.w;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static bmat4 Zero { get; } = new bmat4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static bmat4 Ones { get; } = new bmat4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static bmat4 Identity { get; } = new bmat4(true, false, false, false, false, true, false, false, false, false, true, false, false, false, false, true);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
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
            yield return m30;
            yield return m31;
            yield return m32;
            yield return m33;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (4 x 4 = 16).
        /// </summary>
        public int Count => 16;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int fieldIndex]
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
                    case 12: return m30;
                    case 13: return m31;
                    case 14: return m32;
                    case 15: return m33;
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
                    case 12: this.m30 = value; break;
                    case 13: this.m31 = value; break;
                    case 14: this.m32 = value; break;
                    case 15: this.m33 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int col, int row]
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
        public bool Equals(bmat4 rhs) => ((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m02.Equals(rhs.m02) && m03.Equals(rhs.m03))) && ((m10.Equals(rhs.m10) && m11.Equals(rhs.m11)) && (m12.Equals(rhs.m12) && m13.Equals(rhs.m13)))) && (((m20.Equals(rhs.m20) && m21.Equals(rhs.m21)) && (m22.Equals(rhs.m22) && m23.Equals(rhs.m23))) && ((m30.Equals(rhs.m30) && m31.Equals(rhs.m31)) && (m32.Equals(rhs.m32) && m33.Equals(rhs.m33)))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bmat4 && Equals((bmat4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bmat4 lhs, bmat4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bmat4 lhs, bmat4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((((((((((m00.GetHashCode()) * 2) ^ m01.GetHashCode()) * 2) ^ m02.GetHashCode()) * 2) ^ m03.GetHashCode()) * 2) ^ m10.GetHashCode()) * 2) ^ m11.GetHashCode()) * 2) ^ m12.GetHashCode()) * 2) ^ m13.GetHashCode()) * 2) ^ m20.GetHashCode()) * 2) ^ m21.GetHashCode()) * 2) ^ m22.GetHashCode()) * 2) ^ m23.GetHashCode()) * 2) ^ m30.GetHashCode()) * 2) ^ m31.GetHashCode()) * 2) ^ m32.GetHashCode()) * 2) ^ m33.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public bmat4 Transposed => new bmat4(m00, m10, m20, m30, m01, m11, m21, m31, m02, m12, m22, m32, m03, m13, m23, m33);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public bool MinElement => ((((m00 && m01) && (m02 && m03)) && ((m10 && m11) && (m12 && m13))) && (((m20 && m21) && (m22 && m23)) && ((m30 && m31) && (m32 && m33))));
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public bool MaxElement => ((((m00 || m01) || (m02 || m03)) || ((m10 || m11) || (m12 || m13))) || (((m20 || m21) || (m22 || m23)) || ((m30 || m31) || (m32 || m33))));
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => ((((m00 && m01) && (m02 && m03)) && ((m10 && m11) && (m12 && m13))) && (((m20 && m21) && (m22 && m23)) && ((m30 && m31) && (m32 && m33))));
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => ((((m00 || m01) || (m02 || m03)) || ((m10 || m11) || (m12 || m13))) || (((m20 || m21) || (m22 || m23)) || ((m30 || m31) || (m32 || m33))));
        
        /// <summary>
        /// Executes a component-wise &amp;&amp;. (sorry for different overload but &amp;&amp; cannot be overloaded directly)
        /// </summary>
        public static bmat4 operator&(bmat4 lhs, bmat4 rhs) => new bmat4(lhs.m00 && rhs.m00, lhs.m01 && rhs.m01, lhs.m02 && rhs.m02, lhs.m03 && rhs.m03, lhs.m10 && rhs.m10, lhs.m11 && rhs.m11, lhs.m12 && rhs.m12, lhs.m13 && rhs.m13, lhs.m20 && rhs.m20, lhs.m21 && rhs.m21, lhs.m22 && rhs.m22, lhs.m23 && rhs.m23, lhs.m30 && rhs.m30, lhs.m31 && rhs.m31, lhs.m32 && rhs.m32, lhs.m33 && rhs.m33);
        
        /// <summary>
        /// Executes a component-wise ||. (sorry for different overload but || cannot be overloaded directly)
        /// </summary>
        public static bmat4 operator|(bmat4 lhs, bmat4 rhs) => new bmat4(lhs.m00 || rhs.m00, lhs.m01 || rhs.m01, lhs.m02 || rhs.m02, lhs.m03 || rhs.m03, lhs.m10 || rhs.m10, lhs.m11 || rhs.m11, lhs.m12 || rhs.m12, lhs.m13 || rhs.m13, lhs.m20 || rhs.m20, lhs.m21 || rhs.m21, lhs.m22 || rhs.m22, lhs.m23 || rhs.m23, lhs.m30 || rhs.m30, lhs.m31 || rhs.m31, lhs.m32 || rhs.m32, lhs.m33 || rhs.m33);
    }
}
