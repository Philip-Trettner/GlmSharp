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
    /// A matrix of type long with 4 columns and 4 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct lmat4 : IReadOnlyList<long>, IEquatable<lmat4>
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
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public long m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public long m03;
        
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
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public long m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public long m13;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public long m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public long m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public long m22;
        
        /// <summary>
        /// Column 2, Rows 3
        /// </summary>
        [DataMember]
        public long m23;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        [DataMember]
        public long m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        [DataMember]
        public long m31;
        
        /// <summary>
        /// Column 3, Rows 2
        /// </summary>
        [DataMember]
        public long m32;
        
        /// <summary>
        /// Column 3, Rows 3
        /// </summary>
        [DataMember]
        public long m33;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public lmat4(long m00, long m01, long m02, long m03, long m10, long m11, long m12, long m13, long m20, long m21, long m22, long m23, long m30, long m31, long m32, long m33)
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
        /// Constructs this matrix from a lmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0;
            this.m13 = 0;
            this.m20 = 0;
            this.m21 = 0;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0;
            this.m13 = 0;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0;
            this.m13 = 0;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0;
            this.m20 = 0;
            this.m21 = 0;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = 0;
            this.m21 = 0;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat3x4 m)
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
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lmat4 m)
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
        public lmat4(lvec2 c0, lvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0;
            this.m13 = 0;
            this.m20 = 0;
            this.m21 = 0;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lvec2 c0, lvec2 c1, lvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0;
            this.m13 = 0;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lvec2 c0, lvec2 c1, lvec2 c2, lvec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0;
            this.m03 = 0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0;
            this.m13 = 0;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lvec3 c0, lvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0;
            this.m20 = 0;
            this.m21 = 0;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lvec3 c0, lvec3 c1, lvec3 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lvec3 c0, lvec3 c1, lvec3 c2, lvec3 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = 0;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lvec4 c0, lvec4 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = 0;
            this.m21 = 0;
            this.m22 = 1;
            this.m23 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lvec4 c0, lvec4 c1, lvec4 c2)
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
            this.m30 = 0;
            this.m31 = 0;
            this.m32 = 0;
            this.m33 = 1;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat4(lvec4 c0, lvec4 c1, lvec4 c2, lvec4 c3)
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
        public long[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 }, { m20, m21, m22, m23 }, { m30, m31, m32, m33 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public long[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public lvec4 Column0
        {
            get
            {
                return new lvec4(m00, m01, m02, m03);
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
        public lvec4 Column1
        {
            get
            {
                return new lvec4(m10, m11, m12, m13);
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
        public lvec4 Column2
        {
            get
            {
                return new lvec4(m20, m21, m22, m23);
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
        public lvec4 Column3
        {
            get
            {
                return new lvec4(m30, m31, m32, m33);
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
        public lvec4 Row0
        {
            get
            {
                return new lvec4(m00, m10, m20, m30);
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
        public lvec4 Row1
        {
            get
            {
                return new lvec4(m01, m11, m21, m31);
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
        public lvec4 Row2
        {
            get
            {
                return new lvec4(m02, m12, m22, m32);
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
        public lvec4 Row3
        {
            get
            {
                return new lvec4(m03, m13, m23, m33);
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
        public static lmat4 Zero { get; } = new lmat4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static lmat4 Ones { get; } = new lmat4(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static lmat4 Identity { get; } = new lmat4(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static lmat4 AllMaxValue { get; } = new lmat4(long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static lmat4 DiagonalMaxValue { get; } = new lmat4(long.MaxValue, 0, 0, 0, 0, long.MaxValue, 0, 0, 0, 0, long.MaxValue, 0, 0, 0, 0, long.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static lmat4 AllMinValue { get; } = new lmat4(long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static lmat4 DiagonalMinValue { get; } = new lmat4(long.MinValue, 0, 0, 0, 0, long.MinValue, 0, 0, 0, 0, long.MinValue, 0, 0, 0, 0, long.MinValue);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<long> GetEnumerator()
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
        public long this[int fieldIndex]
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
        public long this[int col, int row]
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
        public bool Equals(lmat4 rhs) => ((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m02.Equals(rhs.m02) && m03.Equals(rhs.m03))) && ((m10.Equals(rhs.m10) && m11.Equals(rhs.m11)) && (m12.Equals(rhs.m12) && m13.Equals(rhs.m13)))) && (((m20.Equals(rhs.m20) && m21.Equals(rhs.m21)) && (m22.Equals(rhs.m22) && m23.Equals(rhs.m23))) && ((m30.Equals(rhs.m30) && m31.Equals(rhs.m31)) && (m32.Equals(rhs.m32) && m33.Equals(rhs.m33)))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is lmat4 && Equals((lmat4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(lmat4 lhs, lmat4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(lmat4 lhs, lmat4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m03.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode()) * 397) ^ m13.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m22.GetHashCode()) * 397) ^ m23.GetHashCode()) * 397) ^ m30.GetHashCode()) * 397) ^ m31.GetHashCode()) * 397) ^ m32.GetHashCode()) * 397) ^ m33.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public lmat4 Transposed => new lmat4(m00, m10, m20, m30, m01, m11, m21, m31, m02, m12, m22, m32, m03, m13, m23, m33);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public long MinElement => Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(m00, m01), m02), m03), m10), m11), m12), m13), m20), m21), m22), m23), m30), m31), m32), m33);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public long MaxElement => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00, m01), m02), m03), m10), m11), m12), m13), m20), m21), m22), m23), m30), m31), m32), m33);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public double Length => (double)Math.Sqrt(((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))) + (((m20*m20 + m21*m21) + (m22*m22 + m23*m23)) + ((m30*m30 + m31*m31) + (m32*m32 + m33*m33)))));
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public double LengthSqr => ((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))) + (((m20*m20 + m21*m21) + (m22*m22 + m23*m23)) + ((m30*m30 + m31*m31) + (m32*m32 + m33*m33))));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public long Sum => ((((m00 + m01) + (m02 + m03)) + ((m10 + m11) + (m12 + m13))) + (((m20 + m21) + (m22 + m23)) + ((m30 + m31) + (m32 + m33))));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public double Norm => (double)Math.Sqrt(((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))) + (((m20*m20 + m21*m21) + (m22*m22 + m23*m23)) + ((m30*m30 + m31*m31) + (m32*m32 + m33*m33)))));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public double Norm1 => ((((Math.Abs(m00) + Math.Abs(m01)) + (Math.Abs(m02) + Math.Abs(m03))) + ((Math.Abs(m10) + Math.Abs(m11)) + (Math.Abs(m12) + Math.Abs(m13)))) + (((Math.Abs(m20) + Math.Abs(m21)) + (Math.Abs(m22) + Math.Abs(m23))) + ((Math.Abs(m30) + Math.Abs(m31)) + (Math.Abs(m32) + Math.Abs(m33)))));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(((((m00*m00 + m01*m01) + (m02*m02 + m03*m03)) + ((m10*m10 + m11*m11) + (m12*m12 + m13*m13))) + (((m20*m20 + m21*m21) + (m22*m22 + m23*m23)) + ((m30*m30 + m31*m31) + (m32*m32 + m33*m33)))));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public long NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(m00), Math.Abs(m01)), Math.Abs(m02)), Math.Abs(m03)), Math.Abs(m10)), Math.Abs(m11)), Math.Abs(m12)), Math.Abs(m13)), Math.Abs(m20)), Math.Abs(m21)), Math.Abs(m22)), Math.Abs(m23)), Math.Abs(m30)), Math.Abs(m31)), Math.Abs(m32)), Math.Abs(m33));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow(((((Math.Pow((double)Math.Abs(m00), p) + Math.Pow((double)Math.Abs(m01), p)) + (Math.Pow((double)Math.Abs(m02), p) + Math.Pow((double)Math.Abs(m03), p))) + ((Math.Pow((double)Math.Abs(m10), p) + Math.Pow((double)Math.Abs(m11), p)) + (Math.Pow((double)Math.Abs(m12), p) + Math.Pow((double)Math.Abs(m13), p)))) + (((Math.Pow((double)Math.Abs(m20), p) + Math.Pow((double)Math.Abs(m21), p)) + (Math.Pow((double)Math.Abs(m22), p) + Math.Pow((double)Math.Abs(m23), p))) + ((Math.Pow((double)Math.Abs(m30), p) + Math.Pow((double)Math.Abs(m31), p)) + (Math.Pow((double)Math.Abs(m32), p) + Math.Pow((double)Math.Abs(m33), p))))), 1 / p);
        
        /// <summary>
        /// Returns determinant of this matrix.
        /// </summary>
        public long Determinant => m00 * (m11 * (m22 * m33 - m32 * m23) - m21 * (m12 * m33 - m32 * m13) + m31 * (m12 * m23 - m22 * m13)) - m10 * (m01 * (m22 * m33 - m32 * m23) - m21 * (m02 * m33 - m32 * m03) + m31 * (m02 * m23 - m22 * m03)) + m20 * (m01 * (m12 * m33 - m32 * m13) - m11 * (m02 * m33 - m32 * m03) + m31 * (m02 * m13 - m12 * m03)) - m30 * (m01 * (m12 * m23 - m22 * m13) - m11 * (m02 * m23 - m22 * m03) + m21 * (m02 * m13 - m12 * m03));
        
        /// <summary>
        /// Returns the adjunct of this matrix.
        /// </summary>
        public lmat4 Adjugate => new lmat4(m11 * (m22 * m33 - m32 * m23) - m21 * (m12 * m33 - m32 * m13) + m31 * (m12 * m23 - m22 * m13), -m01 * (m22 * m33 - m32 * m23) + m21 * (m02 * m33 - m32 * m03) - m31 * (m02 * m23 - m22 * m03), m01 * (m12 * m33 - m32 * m13) - m11 * (m02 * m33 - m32 * m03) + m31 * (m02 * m13 - m12 * m03), -m01 * (m12 * m23 - m22 * m13) + m11 * (m02 * m23 - m22 * m03) - m21 * (m02 * m13 - m12 * m03), -m10 * (m22 * m33 - m32 * m23) + m20 * (m12 * m33 - m32 * m13) - m30 * (m12 * m23 - m22 * m13), m00 * (m22 * m33 - m32 * m23) - m20 * (m02 * m33 - m32 * m03) + m30 * (m02 * m23 - m22 * m03), -m00 * (m12 * m33 - m32 * m13) + m10 * (m02 * m33 - m32 * m03) - m30 * (m02 * m13 - m12 * m03), m00 * (m12 * m23 - m22 * m13) - m10 * (m02 * m23 - m22 * m03) + m20 * (m02 * m13 - m12 * m03), m10 * (m21 * m33 - m31 * m23) - m20 * (m11 * m33 - m31 * m13) + m30 * (m11 * m23 - m21 * m13), -m00 * (m21 * m33 - m31 * m23) + m20 * (m01 * m33 - m31 * m03) - m30 * (m01 * m23 - m21 * m03), m00 * (m11 * m33 - m31 * m13) - m10 * (m01 * m33 - m31 * m03) + m30 * (m01 * m13 - m11 * m03), -m00 * (m11 * m23 - m21 * m13) + m10 * (m01 * m23 - m21 * m03) - m20 * (m01 * m13 - m11 * m03), -m10 * (m21 * m32 - m31 * m22) + m20 * (m11 * m32 - m31 * m12) - m30 * (m11 * m22 - m21 * m12), m00 * (m21 * m32 - m31 * m22) - m20 * (m01 * m32 - m31 * m02) + m30 * (m01 * m22 - m21 * m02), -m00 * (m11 * m32 - m31 * m12) + m10 * (m01 * m32 - m31 * m02) - m30 * (m01 * m12 - m11 * m02), m00 * (m11 * m22 - m21 * m12) - m10 * (m01 * m22 - m21 * m02) + m20 * (m01 * m12 - m11 * m02));
        
        /// <summary>
        /// Returns the inverse of this matrix (use with caution).
        /// </summary>
        public lmat4 Inverse => Adjugate / Determinant;
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat4 * lmat2x4 -> lmat2x4.
        /// </summary>
        public static lmat2x4 operator*(lmat4 lhs, lmat2x4 rhs) => new lmat2x4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + (lhs.m20 * rhs.m02 + lhs.m30 * rhs.m03)), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + (lhs.m21 * rhs.m02 + lhs.m31 * rhs.m03)), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + (lhs.m22 * rhs.m02 + lhs.m32 * rhs.m03)), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + (lhs.m23 * rhs.m02 + lhs.m33 * rhs.m03)), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + (lhs.m20 * rhs.m12 + lhs.m30 * rhs.m13)), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + (lhs.m21 * rhs.m12 + lhs.m31 * rhs.m13)), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + (lhs.m22 * rhs.m12 + lhs.m32 * rhs.m13)), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + (lhs.m23 * rhs.m12 + lhs.m33 * rhs.m13)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat4 * lmat3x4 -> lmat3x4.
        /// </summary>
        public static lmat3x4 operator*(lmat4 lhs, lmat3x4 rhs) => new lmat3x4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + (lhs.m20 * rhs.m02 + lhs.m30 * rhs.m03)), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + (lhs.m21 * rhs.m02 + lhs.m31 * rhs.m03)), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + (lhs.m22 * rhs.m02 + lhs.m32 * rhs.m03)), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + (lhs.m23 * rhs.m02 + lhs.m33 * rhs.m03)), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + (lhs.m20 * rhs.m12 + lhs.m30 * rhs.m13)), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + (lhs.m21 * rhs.m12 + lhs.m31 * rhs.m13)), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + (lhs.m22 * rhs.m12 + lhs.m32 * rhs.m13)), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + (lhs.m23 * rhs.m12 + lhs.m33 * rhs.m13)), ((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + (lhs.m20 * rhs.m22 + lhs.m30 * rhs.m23)), ((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + (lhs.m21 * rhs.m22 + lhs.m31 * rhs.m23)), ((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + (lhs.m22 * rhs.m22 + lhs.m32 * rhs.m23)), ((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + (lhs.m23 * rhs.m22 + lhs.m33 * rhs.m23)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat4 * lmat4 -> lmat4.
        /// </summary>
        public static lmat4 operator*(lmat4 lhs, lmat4 rhs) => new lmat4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + (lhs.m20 * rhs.m02 + lhs.m30 * rhs.m03)), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + (lhs.m21 * rhs.m02 + lhs.m31 * rhs.m03)), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + (lhs.m22 * rhs.m02 + lhs.m32 * rhs.m03)), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + (lhs.m23 * rhs.m02 + lhs.m33 * rhs.m03)), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + (lhs.m20 * rhs.m12 + lhs.m30 * rhs.m13)), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + (lhs.m21 * rhs.m12 + lhs.m31 * rhs.m13)), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + (lhs.m22 * rhs.m12 + lhs.m32 * rhs.m13)), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + (lhs.m23 * rhs.m12 + lhs.m33 * rhs.m13)), ((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + (lhs.m20 * rhs.m22 + lhs.m30 * rhs.m23)), ((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + (lhs.m21 * rhs.m22 + lhs.m31 * rhs.m23)), ((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + (lhs.m22 * rhs.m22 + lhs.m32 * rhs.m23)), ((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + (lhs.m23 * rhs.m22 + lhs.m33 * rhs.m23)), ((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + (lhs.m20 * rhs.m32 + lhs.m30 * rhs.m33)), ((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + (lhs.m21 * rhs.m32 + lhs.m31 * rhs.m33)), ((lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31) + (lhs.m22 * rhs.m32 + lhs.m32 * rhs.m33)), ((lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31) + (lhs.m23 * rhs.m32 + lhs.m33 * rhs.m33)));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static lvec4 operator*(lmat4 m, lvec4 v) => new lvec4(((m.m00 * v.x + m.m10 * v.y) + (m.m20 * v.z + m.m30 * v.w)), ((m.m01 * v.x + m.m11 * v.y) + (m.m21 * v.z + m.m31 * v.w)), ((m.m02 * v.x + m.m12 * v.y) + (m.m22 * v.z + m.m32 * v.w)), ((m.m03 * v.x + m.m13 * v.y) + (m.m23 * v.z + m.m33 * v.w)));
        
        /// <summary>
        /// Executes a matrix-matrix-divison A / B == A * B^-1 (use with caution).
        /// </summary>
        public static lmat4 operator/(lmat4 A, lmat4 B) => A * B.Inverse;
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static lmat4 CompMul(lmat4 A, lmat4 B) => new lmat4(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m03 * B.m03, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12, A.m13 * B.m13, A.m20 * B.m20, A.m21 * B.m21, A.m22 * B.m22, A.m23 * B.m23, A.m30 * B.m30, A.m31 * B.m31, A.m32 * B.m32, A.m33 * B.m33);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static lmat4 CompDiv(lmat4 A, lmat4 B) => new lmat4(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m03 / B.m03, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12, A.m13 / B.m13, A.m20 / B.m20, A.m21 / B.m21, A.m22 / B.m22, A.m23 / B.m23, A.m30 / B.m30, A.m31 / B.m31, A.m32 / B.m32, A.m33 / B.m33);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static lmat4 CompAdd(lmat4 A, lmat4 B) => new lmat4(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m03 + B.m03, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12, A.m13 + B.m13, A.m20 + B.m20, A.m21 + B.m21, A.m22 + B.m22, A.m23 + B.m23, A.m30 + B.m30, A.m31 + B.m31, A.m32 + B.m32, A.m33 + B.m33);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static lmat4 CompSub(lmat4 A, lmat4 B) => new lmat4(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m03 - B.m03, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12, A.m13 - B.m13, A.m20 - B.m20, A.m21 - B.m21, A.m22 - B.m22, A.m23 - B.m23, A.m30 - B.m30, A.m31 - B.m31, A.m32 - B.m32, A.m33 - B.m33);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static lmat4 operator+(lmat4 lhs, lmat4 rhs) => new lmat4(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m03 + rhs.m03, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13, lhs.m20 + rhs.m20, lhs.m21 + rhs.m21, lhs.m22 + rhs.m22, lhs.m23 + rhs.m23, lhs.m30 + rhs.m30, lhs.m31 + rhs.m31, lhs.m32 + rhs.m32, lhs.m33 + rhs.m33);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static lmat4 operator+(lmat4 lhs, long rhs) => new lmat4(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m03 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m13 + rhs, lhs.m20 + rhs, lhs.m21 + rhs, lhs.m22 + rhs, lhs.m23 + rhs, lhs.m30 + rhs, lhs.m31 + rhs, lhs.m32 + rhs, lhs.m33 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static lmat4 operator+(long lhs, lmat4 rhs) => new lmat4(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m03, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m13, lhs + rhs.m20, lhs + rhs.m21, lhs + rhs.m22, lhs + rhs.m23, lhs + rhs.m30, lhs + rhs.m31, lhs + rhs.m32, lhs + rhs.m33);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static lmat4 operator-(lmat4 lhs, lmat4 rhs) => new lmat4(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m03 - rhs.m03, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13, lhs.m20 - rhs.m20, lhs.m21 - rhs.m21, lhs.m22 - rhs.m22, lhs.m23 - rhs.m23, lhs.m30 - rhs.m30, lhs.m31 - rhs.m31, lhs.m32 - rhs.m32, lhs.m33 - rhs.m33);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static lmat4 operator-(lmat4 lhs, long rhs) => new lmat4(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m03 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m13 - rhs, lhs.m20 - rhs, lhs.m21 - rhs, lhs.m22 - rhs, lhs.m23 - rhs, lhs.m30 - rhs, lhs.m31 - rhs, lhs.m32 - rhs, lhs.m33 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static lmat4 operator-(long lhs, lmat4 rhs) => new lmat4(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m03, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m13, lhs - rhs.m20, lhs - rhs.m21, lhs - rhs.m22, lhs - rhs.m23, lhs - rhs.m30, lhs - rhs.m31, lhs - rhs.m32, lhs - rhs.m33);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static lmat4 operator/(lmat4 lhs, long rhs) => new lmat4(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m03 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs, lhs.m13 / rhs, lhs.m20 / rhs, lhs.m21 / rhs, lhs.m22 / rhs, lhs.m23 / rhs, lhs.m30 / rhs, lhs.m31 / rhs, lhs.m32 / rhs, lhs.m33 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static lmat4 operator/(long lhs, lmat4 rhs) => new lmat4(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m03, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12, lhs / rhs.m13, lhs / rhs.m20, lhs / rhs.m21, lhs / rhs.m22, lhs / rhs.m23, lhs / rhs.m30, lhs / rhs.m31, lhs / rhs.m32, lhs / rhs.m33);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static lmat4 operator*(lmat4 lhs, long rhs) => new lmat4(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m03 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs, lhs.m13 * rhs, lhs.m20 * rhs, lhs.m21 * rhs, lhs.m22 * rhs, lhs.m23 * rhs, lhs.m30 * rhs, lhs.m31 * rhs, lhs.m32 * rhs, lhs.m33 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static lmat4 operator*(long lhs, lmat4 rhs) => new lmat4(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m03, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12, lhs * rhs.m13, lhs * rhs.m20, lhs * rhs.m21, lhs * rhs.m22, lhs * rhs.m23, lhs * rhs.m30, lhs * rhs.m31, lhs * rhs.m32, lhs * rhs.m33);
        
        /// <summary>
        /// Executes a component-wise % (modulo).
        /// </summary>
        public static lmat4 operator%(lmat4 lhs, lmat4 rhs) => new lmat4(lhs.m00 % rhs.m00, lhs.m01 % rhs.m01, lhs.m02 % rhs.m02, lhs.m03 % rhs.m03, lhs.m10 % rhs.m10, lhs.m11 % rhs.m11, lhs.m12 % rhs.m12, lhs.m13 % rhs.m13, lhs.m20 % rhs.m20, lhs.m21 % rhs.m21, lhs.m22 % rhs.m22, lhs.m23 % rhs.m23, lhs.m30 % rhs.m30, lhs.m31 % rhs.m31, lhs.m32 % rhs.m32, lhs.m33 % rhs.m33);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static lmat4 operator%(lmat4 lhs, long rhs) => new lmat4(lhs.m00 % rhs, lhs.m01 % rhs, lhs.m02 % rhs, lhs.m03 % rhs, lhs.m10 % rhs, lhs.m11 % rhs, lhs.m12 % rhs, lhs.m13 % rhs, lhs.m20 % rhs, lhs.m21 % rhs, lhs.m22 % rhs, lhs.m23 % rhs, lhs.m30 % rhs, lhs.m31 % rhs, lhs.m32 % rhs, lhs.m33 % rhs);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static lmat4 operator%(long lhs, lmat4 rhs) => new lmat4(lhs % rhs.m00, lhs % rhs.m01, lhs % rhs.m02, lhs % rhs.m03, lhs % rhs.m10, lhs % rhs.m11, lhs % rhs.m12, lhs % rhs.m13, lhs % rhs.m20, lhs % rhs.m21, lhs % rhs.m22, lhs % rhs.m23, lhs % rhs.m30, lhs % rhs.m31, lhs % rhs.m32, lhs % rhs.m33);
        
        /// <summary>
        /// Executes a component-wise ^ (xor).
        /// </summary>
        public static lmat4 operator^(lmat4 lhs, lmat4 rhs) => new lmat4(lhs.m00 ^ rhs.m00, lhs.m01 ^ rhs.m01, lhs.m02 ^ rhs.m02, lhs.m03 ^ rhs.m03, lhs.m10 ^ rhs.m10, lhs.m11 ^ rhs.m11, lhs.m12 ^ rhs.m12, lhs.m13 ^ rhs.m13, lhs.m20 ^ rhs.m20, lhs.m21 ^ rhs.m21, lhs.m22 ^ rhs.m22, lhs.m23 ^ rhs.m23, lhs.m30 ^ rhs.m30, lhs.m31 ^ rhs.m31, lhs.m32 ^ rhs.m32, lhs.m33 ^ rhs.m33);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static lmat4 operator^(lmat4 lhs, long rhs) => new lmat4(lhs.m00 ^ rhs, lhs.m01 ^ rhs, lhs.m02 ^ rhs, lhs.m03 ^ rhs, lhs.m10 ^ rhs, lhs.m11 ^ rhs, lhs.m12 ^ rhs, lhs.m13 ^ rhs, lhs.m20 ^ rhs, lhs.m21 ^ rhs, lhs.m22 ^ rhs, lhs.m23 ^ rhs, lhs.m30 ^ rhs, lhs.m31 ^ rhs, lhs.m32 ^ rhs, lhs.m33 ^ rhs);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static lmat4 operator^(long lhs, lmat4 rhs) => new lmat4(lhs ^ rhs.m00, lhs ^ rhs.m01, lhs ^ rhs.m02, lhs ^ rhs.m03, lhs ^ rhs.m10, lhs ^ rhs.m11, lhs ^ rhs.m12, lhs ^ rhs.m13, lhs ^ rhs.m20, lhs ^ rhs.m21, lhs ^ rhs.m22, lhs ^ rhs.m23, lhs ^ rhs.m30, lhs ^ rhs.m31, lhs ^ rhs.m32, lhs ^ rhs.m33);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or).
        /// </summary>
        public static lmat4 operator|(lmat4 lhs, lmat4 rhs) => new lmat4(lhs.m00 | rhs.m00, lhs.m01 | rhs.m01, lhs.m02 | rhs.m02, lhs.m03 | rhs.m03, lhs.m10 | rhs.m10, lhs.m11 | rhs.m11, lhs.m12 | rhs.m12, lhs.m13 | rhs.m13, lhs.m20 | rhs.m20, lhs.m21 | rhs.m21, lhs.m22 | rhs.m22, lhs.m23 | rhs.m23, lhs.m30 | rhs.m30, lhs.m31 | rhs.m31, lhs.m32 | rhs.m32, lhs.m33 | rhs.m33);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static lmat4 operator|(lmat4 lhs, long rhs) => new lmat4(lhs.m00 | rhs, lhs.m01 | rhs, lhs.m02 | rhs, lhs.m03 | rhs, lhs.m10 | rhs, lhs.m11 | rhs, lhs.m12 | rhs, lhs.m13 | rhs, lhs.m20 | rhs, lhs.m21 | rhs, lhs.m22 | rhs, lhs.m23 | rhs, lhs.m30 | rhs, lhs.m31 | rhs, lhs.m32 | rhs, lhs.m33 | rhs);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static lmat4 operator|(long lhs, lmat4 rhs) => new lmat4(lhs | rhs.m00, lhs | rhs.m01, lhs | rhs.m02, lhs | rhs.m03, lhs | rhs.m10, lhs | rhs.m11, lhs | rhs.m12, lhs | rhs.m13, lhs | rhs.m20, lhs | rhs.m21, lhs | rhs.m22, lhs | rhs.m23, lhs | rhs.m30, lhs | rhs.m31, lhs | rhs.m32, lhs | rhs.m33);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and).
        /// </summary>
        public static lmat4 operator&(lmat4 lhs, lmat4 rhs) => new lmat4(lhs.m00 & rhs.m00, lhs.m01 & rhs.m01, lhs.m02 & rhs.m02, lhs.m03 & rhs.m03, lhs.m10 & rhs.m10, lhs.m11 & rhs.m11, lhs.m12 & rhs.m12, lhs.m13 & rhs.m13, lhs.m20 & rhs.m20, lhs.m21 & rhs.m21, lhs.m22 & rhs.m22, lhs.m23 & rhs.m23, lhs.m30 & rhs.m30, lhs.m31 & rhs.m31, lhs.m32 & rhs.m32, lhs.m33 & rhs.m33);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and) with a scalar.
        /// </summary>
        public static lmat4 operator&(lmat4 lhs, long rhs) => new lmat4(lhs.m00 & rhs, lhs.m01 & rhs, lhs.m02 & rhs, lhs.m03 & rhs, lhs.m10 & rhs, lhs.m11 & rhs, lhs.m12 & rhs, lhs.m13 & rhs, lhs.m20 & rhs, lhs.m21 & rhs, lhs.m22 & rhs, lhs.m23 & rhs, lhs.m30 & rhs, lhs.m31 & rhs, lhs.m32 & rhs, lhs.m33 & rhs);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and) with a scalar.
        /// </summary>
        public static lmat4 operator&(long lhs, lmat4 rhs) => new lmat4(lhs & rhs.m00, lhs & rhs.m01, lhs & rhs.m02, lhs & rhs.m03, lhs & rhs.m10, lhs & rhs.m11, lhs & rhs.m12, lhs & rhs.m13, lhs & rhs.m20, lhs & rhs.m21, lhs & rhs.m22, lhs & rhs.m23, lhs & rhs.m30, lhs & rhs.m31, lhs & rhs.m32, lhs & rhs.m33);
        
        /// <summary>
        /// Executes a component-wise left-shift with a scalar.
        /// </summary>
        public static lmat4 operator<<(lmat4 lhs, int rhs) => new lmat4(lhs.m00 << rhs, lhs.m01 << rhs, lhs.m02 << rhs, lhs.m03 << rhs, lhs.m10 << rhs, lhs.m11 << rhs, lhs.m12 << rhs, lhs.m13 << rhs, lhs.m20 << rhs, lhs.m21 << rhs, lhs.m22 << rhs, lhs.m23 << rhs, lhs.m30 << rhs, lhs.m31 << rhs, lhs.m32 << rhs, lhs.m33 << rhs);
        
        /// <summary>
        /// Executes a component-wise right-shift with a scalar.
        /// </summary>
        public static lmat4 operator>>(lmat4 lhs, int rhs) => new lmat4(lhs.m00 >> rhs, lhs.m01 >> rhs, lhs.m02 >> rhs, lhs.m03 >> rhs, lhs.m10 >> rhs, lhs.m11 >> rhs, lhs.m12 >> rhs, lhs.m13 >> rhs, lhs.m20 >> rhs, lhs.m21 >> rhs, lhs.m22 >> rhs, lhs.m23 >> rhs, lhs.m30 >> rhs, lhs.m31 >> rhs, lhs.m32 >> rhs, lhs.m33 >> rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat4 operator<(lmat4 lhs, lmat4 rhs) => new bmat4(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m02 < rhs.m02, lhs.m03 < rhs.m03, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11, lhs.m12 < rhs.m12, lhs.m13 < rhs.m13, lhs.m20 < rhs.m20, lhs.m21 < rhs.m21, lhs.m22 < rhs.m22, lhs.m23 < rhs.m23, lhs.m30 < rhs.m30, lhs.m31 < rhs.m31, lhs.m32 < rhs.m32, lhs.m33 < rhs.m33);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat4 operator<(lmat4 lhs, long rhs) => new bmat4(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m02 < rhs, lhs.m03 < rhs, lhs.m10 < rhs, lhs.m11 < rhs, lhs.m12 < rhs, lhs.m13 < rhs, lhs.m20 < rhs, lhs.m21 < rhs, lhs.m22 < rhs, lhs.m23 < rhs, lhs.m30 < rhs, lhs.m31 < rhs, lhs.m32 < rhs, lhs.m33 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat4 operator<(long lhs, lmat4 rhs) => new bmat4(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m02, lhs < rhs.m03, lhs < rhs.m10, lhs < rhs.m11, lhs < rhs.m12, lhs < rhs.m13, lhs < rhs.m20, lhs < rhs.m21, lhs < rhs.m22, lhs < rhs.m23, lhs < rhs.m30, lhs < rhs.m31, lhs < rhs.m32, lhs < rhs.m33);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat4 operator<=(lmat4 lhs, lmat4 rhs) => new bmat4(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m02 <= rhs.m02, lhs.m03 <= rhs.m03, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11, lhs.m12 <= rhs.m12, lhs.m13 <= rhs.m13, lhs.m20 <= rhs.m20, lhs.m21 <= rhs.m21, lhs.m22 <= rhs.m22, lhs.m23 <= rhs.m23, lhs.m30 <= rhs.m30, lhs.m31 <= rhs.m31, lhs.m32 <= rhs.m32, lhs.m33 <= rhs.m33);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat4 operator<=(lmat4 lhs, long rhs) => new bmat4(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m02 <= rhs, lhs.m03 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs, lhs.m12 <= rhs, lhs.m13 <= rhs, lhs.m20 <= rhs, lhs.m21 <= rhs, lhs.m22 <= rhs, lhs.m23 <= rhs, lhs.m30 <= rhs, lhs.m31 <= rhs, lhs.m32 <= rhs, lhs.m33 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat4 operator<=(long lhs, lmat4 rhs) => new bmat4(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m02, lhs <= rhs.m03, lhs <= rhs.m10, lhs <= rhs.m11, lhs <= rhs.m12, lhs <= rhs.m13, lhs <= rhs.m20, lhs <= rhs.m21, lhs <= rhs.m22, lhs <= rhs.m23, lhs <= rhs.m30, lhs <= rhs.m31, lhs <= rhs.m32, lhs <= rhs.m33);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat4 operator>(lmat4 lhs, lmat4 rhs) => new bmat4(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m02 > rhs.m02, lhs.m03 > rhs.m03, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11, lhs.m12 > rhs.m12, lhs.m13 > rhs.m13, lhs.m20 > rhs.m20, lhs.m21 > rhs.m21, lhs.m22 > rhs.m22, lhs.m23 > rhs.m23, lhs.m30 > rhs.m30, lhs.m31 > rhs.m31, lhs.m32 > rhs.m32, lhs.m33 > rhs.m33);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat4 operator>(lmat4 lhs, long rhs) => new bmat4(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m02 > rhs, lhs.m03 > rhs, lhs.m10 > rhs, lhs.m11 > rhs, lhs.m12 > rhs, lhs.m13 > rhs, lhs.m20 > rhs, lhs.m21 > rhs, lhs.m22 > rhs, lhs.m23 > rhs, lhs.m30 > rhs, lhs.m31 > rhs, lhs.m32 > rhs, lhs.m33 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat4 operator>(long lhs, lmat4 rhs) => new bmat4(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m02, lhs > rhs.m03, lhs > rhs.m10, lhs > rhs.m11, lhs > rhs.m12, lhs > rhs.m13, lhs > rhs.m20, lhs > rhs.m21, lhs > rhs.m22, lhs > rhs.m23, lhs > rhs.m30, lhs > rhs.m31, lhs > rhs.m32, lhs > rhs.m33);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat4 operator>=(lmat4 lhs, lmat4 rhs) => new bmat4(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m02 >= rhs.m02, lhs.m03 >= rhs.m03, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11, lhs.m12 >= rhs.m12, lhs.m13 >= rhs.m13, lhs.m20 >= rhs.m20, lhs.m21 >= rhs.m21, lhs.m22 >= rhs.m22, lhs.m23 >= rhs.m23, lhs.m30 >= rhs.m30, lhs.m31 >= rhs.m31, lhs.m32 >= rhs.m32, lhs.m33 >= rhs.m33);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat4 operator>=(lmat4 lhs, long rhs) => new bmat4(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m02 >= rhs, lhs.m03 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs, lhs.m12 >= rhs, lhs.m13 >= rhs, lhs.m20 >= rhs, lhs.m21 >= rhs, lhs.m22 >= rhs, lhs.m23 >= rhs, lhs.m30 >= rhs, lhs.m31 >= rhs, lhs.m32 >= rhs, lhs.m33 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat4 operator>=(long lhs, lmat4 rhs) => new bmat4(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m02, lhs >= rhs.m03, lhs >= rhs.m10, lhs >= rhs.m11, lhs >= rhs.m12, lhs >= rhs.m13, lhs >= rhs.m20, lhs >= rhs.m21, lhs >= rhs.m22, lhs >= rhs.m23, lhs >= rhs.m30, lhs >= rhs.m31, lhs >= rhs.m32, lhs >= rhs.m33);
    }
}
