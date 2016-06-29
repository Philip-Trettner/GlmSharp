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
    /// A matrix of type double with 4 columns and 4 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct dmat4 : IReadOnlyList<double>, IEquatable<dmat4>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public double m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public double m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public double m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public double m03;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public double m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public double m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public double m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public double m13;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public double m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public double m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public double m22;
        
        /// <summary>
        /// Column 2, Rows 3
        /// </summary>
        [DataMember]
        public double m23;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        [DataMember]
        public double m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        [DataMember]
        public double m31;
        
        /// <summary>
        /// Column 3, Rows 2
        /// </summary>
        [DataMember]
        public double m32;
        
        /// <summary>
        /// Column 3, Rows 3
        /// </summary>
        [DataMember]
        public double m33;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dmat4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
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
        /// Constructs this matrix from a dmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0.0;
            this.m03 = 0.0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0.0;
            this.m13 = 0.0;
            this.m20 = 0.0;
            this.m21 = 0.0;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a dmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0.0;
            this.m03 = 0.0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0.0;
            this.m13 = 0.0;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a dmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0.0;
            this.m03 = 0.0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0.0;
            this.m13 = 0.0;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a dmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0.0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0.0;
            this.m20 = 0.0;
            this.m21 = 0.0;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a dmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0.0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0.0;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a dmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0.0;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0.0;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0.0;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a dmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = 0.0;
            this.m21 = 0.0;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a dmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat3x4 m)
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
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a dmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dmat4 m)
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
        public dmat4(dvec2 c0, dvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0.0;
            this.m03 = 0.0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0.0;
            this.m13 = 0.0;
            this.m20 = 0.0;
            this.m21 = 0.0;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dvec2 c0, dvec2 c1, dvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0.0;
            this.m03 = 0.0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0.0;
            this.m13 = 0.0;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dvec2 c0, dvec2 c1, dvec2 c2, dvec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0.0;
            this.m03 = 0.0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0.0;
            this.m13 = 0.0;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dvec3 c0, dvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0.0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0.0;
            this.m20 = 0.0;
            this.m21 = 0.0;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dvec3 c0, dvec3 c1, dvec3 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0.0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0.0;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dvec3 c0, dvec3 c1, dvec3 c2, dvec3 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0.0;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0.0;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = 0.0;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dvec4 c0, dvec4 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = 0.0;
            this.m21 = 0.0;
            this.m22 = 1.0;
            this.m23 = 0.0;
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dvec4 c0, dvec4 c1, dvec4 c2)
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
            this.m30 = 0.0;
            this.m31 = 0.0;
            this.m32 = 0.0;
            this.m33 = 1.0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public dmat4(dvec4 c0, dvec4 c1, dvec4 c2, dvec4 c3)
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
        
        /// <summary>
        /// Creates a rotation matrix from a dquat.
        /// </summary>
        public dmat4(dquat  q)
            : this(q.ToMat4)
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Creates a rotation matrix from a dquat.
        /// </summary>
        public static explicit operator dmat4(dquat  q) => q.ToMat4;

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public double[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 }, { m20, m21, m22, m23 }, { m30, m31, m32, m33 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public double[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public dvec4 Column0
        {
            get
            {
                return new dvec4(m00, m01, m02, m03);
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
        public dvec4 Column1
        {
            get
            {
                return new dvec4(m10, m11, m12, m13);
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
        public dvec4 Column2
        {
            get
            {
                return new dvec4(m20, m21, m22, m23);
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
        public dvec4 Column3
        {
            get
            {
                return new dvec4(m30, m31, m32, m33);
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
        public dvec4 Row0
        {
            get
            {
                return new dvec4(m00, m10, m20, m30);
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
        public dvec4 Row1
        {
            get
            {
                return new dvec4(m01, m11, m21, m31);
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
        public dvec4 Row2
        {
            get
            {
                return new dvec4(m02, m12, m22, m32);
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
        public dvec4 Row3
        {
            get
            {
                return new dvec4(m03, m13, m23, m33);
            }
            set
            {
                m03 = value.x;
                m13 = value.y;
                m23 = value.z;
                m33 = value.w;
            }
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of this matrix.
        /// </summary>
        public dquat ToQuaternion => dquat.FromMat4(this);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static dmat4 Zero { get; } = new dmat4(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static dmat4 Ones { get; } = new dmat4(1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static dmat4 Identity { get; } = new dmat4(1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static dmat4 AllMaxValue { get; } = new dmat4(double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static dmat4 DiagonalMaxValue { get; } = new dmat4(double.MaxValue, 0.0, 0.0, 0.0, 0.0, double.MaxValue, 0.0, 0.0, 0.0, 0.0, double.MaxValue, 0.0, 0.0, 0.0, 0.0, double.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static dmat4 AllMinValue { get; } = new dmat4(double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static dmat4 DiagonalMinValue { get; } = new dmat4(double.MinValue, 0.0, 0.0, 0.0, 0.0, double.MinValue, 0.0, 0.0, 0.0, 0.0, double.MinValue, 0.0, 0.0, 0.0, 0.0, double.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon matrix
        /// </summary>
        public static dmat4 AllEpsilon { get; } = new dmat4(double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon);
        
        /// <summary>
        /// Predefined diagonal-Epsilon matrix
        /// </summary>
        public static dmat4 DiagonalEpsilon { get; } = new dmat4(double.Epsilon, 0.0, 0.0, 0.0, 0.0, double.Epsilon, 0.0, 0.0, 0.0, 0.0, double.Epsilon, 0.0, 0.0, 0.0, 0.0, double.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN matrix
        /// </summary>
        public static dmat4 AllNaN { get; } = new dmat4(double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN);
        
        /// <summary>
        /// Predefined diagonal-NaN matrix
        /// </summary>
        public static dmat4 DiagonalNaN { get; } = new dmat4(double.NaN, 0.0, 0.0, 0.0, 0.0, double.NaN, 0.0, 0.0, 0.0, 0.0, double.NaN, 0.0, 0.0, 0.0, 0.0, double.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity matrix
        /// </summary>
        public static dmat4 AllNegativeInfinity { get; } = new dmat4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
        
        /// <summary>
        /// Predefined diagonal-NegativeInfinity matrix
        /// </summary>
        public static dmat4 DiagonalNegativeInfinity { get; } = new dmat4(double.NegativeInfinity, 0.0, 0.0, 0.0, 0.0, double.NegativeInfinity, 0.0, 0.0, 0.0, 0.0, double.NegativeInfinity, 0.0, 0.0, 0.0, 0.0, double.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity matrix
        /// </summary>
        public static dmat4 AllPositiveInfinity { get; } = new dmat4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);
        
        /// <summary>
        /// Predefined diagonal-PositiveInfinity matrix
        /// </summary>
        public static dmat4 DiagonalPositiveInfinity { get; } = new dmat4(double.PositiveInfinity, 0.0, 0.0, 0.0, 0.0, double.PositiveInfinity, 0.0, 0.0, 0.0, 0.0, double.PositiveInfinity, 0.0, 0.0, 0.0, 0.0, double.PositiveInfinity);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
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
        public double this[int fieldIndex]
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
        public double this[int col, int row]
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
        public bool Equals(dmat4 rhs) => ((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m02.Equals(rhs.m02) && m03.Equals(rhs.m03))) && ((m10.Equals(rhs.m10) && m11.Equals(rhs.m11)) && (m12.Equals(rhs.m12) && m13.Equals(rhs.m13)))) && (((m20.Equals(rhs.m20) && m21.Equals(rhs.m21)) && (m22.Equals(rhs.m22) && m23.Equals(rhs.m23))) && ((m30.Equals(rhs.m30) && m31.Equals(rhs.m31)) && (m32.Equals(rhs.m32) && m33.Equals(rhs.m33)))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is dmat4 && Equals((dmat4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(dmat4 lhs, dmat4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(dmat4 lhs, dmat4 rhs) => !lhs.Equals(rhs);
        
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
        public dmat4 Transposed => new dmat4(m00, m10, m20, m30, m01, m11, m21, m31, m02, m12, m22, m32, m03, m13, m23, m33);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public double MinElement => Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(m00, m01), m02), m03), m10), m11), m12), m13), m20), m21), m22), m23), m30), m31), m32), m33);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public double MaxElement => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00, m01), m02), m03), m10), m11), m12), m13), m20), m21), m22), m23), m30), m31), m32), m33);
        
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
        public double Sum => ((((m00 + m01) + (m02 + m03)) + ((m10 + m11) + (m12 + m13))) + (((m20 + m21) + (m22 + m23)) + ((m30 + m31) + (m32 + m33))));
        
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
        public double NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(m00), Math.Abs(m01)), Math.Abs(m02)), Math.Abs(m03)), Math.Abs(m10)), Math.Abs(m11)), Math.Abs(m12)), Math.Abs(m13)), Math.Abs(m20)), Math.Abs(m21)), Math.Abs(m22)), Math.Abs(m23)), Math.Abs(m30)), Math.Abs(m31)), Math.Abs(m32)), Math.Abs(m33));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow(((((Math.Pow((double)Math.Abs(m00), p) + Math.Pow((double)Math.Abs(m01), p)) + (Math.Pow((double)Math.Abs(m02), p) + Math.Pow((double)Math.Abs(m03), p))) + ((Math.Pow((double)Math.Abs(m10), p) + Math.Pow((double)Math.Abs(m11), p)) + (Math.Pow((double)Math.Abs(m12), p) + Math.Pow((double)Math.Abs(m13), p)))) + (((Math.Pow((double)Math.Abs(m20), p) + Math.Pow((double)Math.Abs(m21), p)) + (Math.Pow((double)Math.Abs(m22), p) + Math.Pow((double)Math.Abs(m23), p))) + ((Math.Pow((double)Math.Abs(m30), p) + Math.Pow((double)Math.Abs(m31), p)) + (Math.Pow((double)Math.Abs(m32), p) + Math.Pow((double)Math.Abs(m33), p))))), 1 / p);
        
        /// <summary>
        /// Returns determinant of this matrix.
        /// </summary>
        public double Determinant => m00 * (m11 * (m22 * m33 - m32 * m23) - m21 * (m12 * m33 - m32 * m13) + m31 * (m12 * m23 - m22 * m13)) - m10 * (m01 * (m22 * m33 - m32 * m23) - m21 * (m02 * m33 - m32 * m03) + m31 * (m02 * m23 - m22 * m03)) + m20 * (m01 * (m12 * m33 - m32 * m13) - m11 * (m02 * m33 - m32 * m03) + m31 * (m02 * m13 - m12 * m03)) - m30 * (m01 * (m12 * m23 - m22 * m13) - m11 * (m02 * m23 - m22 * m03) + m21 * (m02 * m13 - m12 * m03));
        
        /// <summary>
        /// Returns the adjunct of this matrix.
        /// </summary>
        public dmat4 Adjugate => new dmat4(m11 * (m22 * m33 - m32 * m23) - m21 * (m12 * m33 - m32 * m13) + m31 * (m12 * m23 - m22 * m13), -m01 * (m22 * m33 - m32 * m23) + m21 * (m02 * m33 - m32 * m03) - m31 * (m02 * m23 - m22 * m03), m01 * (m12 * m33 - m32 * m13) - m11 * (m02 * m33 - m32 * m03) + m31 * (m02 * m13 - m12 * m03), -m01 * (m12 * m23 - m22 * m13) + m11 * (m02 * m23 - m22 * m03) - m21 * (m02 * m13 - m12 * m03), -m10 * (m22 * m33 - m32 * m23) + m20 * (m12 * m33 - m32 * m13) - m30 * (m12 * m23 - m22 * m13), m00 * (m22 * m33 - m32 * m23) - m20 * (m02 * m33 - m32 * m03) + m30 * (m02 * m23 - m22 * m03), -m00 * (m12 * m33 - m32 * m13) + m10 * (m02 * m33 - m32 * m03) - m30 * (m02 * m13 - m12 * m03), m00 * (m12 * m23 - m22 * m13) - m10 * (m02 * m23 - m22 * m03) + m20 * (m02 * m13 - m12 * m03), m10 * (m21 * m33 - m31 * m23) - m20 * (m11 * m33 - m31 * m13) + m30 * (m11 * m23 - m21 * m13), -m00 * (m21 * m33 - m31 * m23) + m20 * (m01 * m33 - m31 * m03) - m30 * (m01 * m23 - m21 * m03), m00 * (m11 * m33 - m31 * m13) - m10 * (m01 * m33 - m31 * m03) + m30 * (m01 * m13 - m11 * m03), -m00 * (m11 * m23 - m21 * m13) + m10 * (m01 * m23 - m21 * m03) - m20 * (m01 * m13 - m11 * m03), -m10 * (m21 * m32 - m31 * m22) + m20 * (m11 * m32 - m31 * m12) - m30 * (m11 * m22 - m21 * m12), m00 * (m21 * m32 - m31 * m22) - m20 * (m01 * m32 - m31 * m02) + m30 * (m01 * m22 - m21 * m02), -m00 * (m11 * m32 - m31 * m12) + m10 * (m01 * m32 - m31 * m02) - m30 * (m01 * m12 - m11 * m02), m00 * (m11 * m22 - m21 * m12) - m10 * (m01 * m22 - m21 * m02) + m20 * (m01 * m12 - m11 * m02));
        
        /// <summary>
        /// Returns the inverse of this matrix (use with caution).
        /// </summary>
        public dmat4 Inverse => Adjugate / Determinant;
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication dmat4 * dmat2x4 -> dmat2x4.
        /// </summary>
        public static dmat2x4 operator*(dmat4 lhs, dmat2x4 rhs) => new dmat2x4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + (lhs.m20 * rhs.m02 + lhs.m30 * rhs.m03)), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + (lhs.m21 * rhs.m02 + lhs.m31 * rhs.m03)), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + (lhs.m22 * rhs.m02 + lhs.m32 * rhs.m03)), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + (lhs.m23 * rhs.m02 + lhs.m33 * rhs.m03)), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + (lhs.m20 * rhs.m12 + lhs.m30 * rhs.m13)), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + (lhs.m21 * rhs.m12 + lhs.m31 * rhs.m13)), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + (lhs.m22 * rhs.m12 + lhs.m32 * rhs.m13)), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + (lhs.m23 * rhs.m12 + lhs.m33 * rhs.m13)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication dmat4 * dmat3x4 -> dmat3x4.
        /// </summary>
        public static dmat3x4 operator*(dmat4 lhs, dmat3x4 rhs) => new dmat3x4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + (lhs.m20 * rhs.m02 + lhs.m30 * rhs.m03)), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + (lhs.m21 * rhs.m02 + lhs.m31 * rhs.m03)), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + (lhs.m22 * rhs.m02 + lhs.m32 * rhs.m03)), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + (lhs.m23 * rhs.m02 + lhs.m33 * rhs.m03)), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + (lhs.m20 * rhs.m12 + lhs.m30 * rhs.m13)), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + (lhs.m21 * rhs.m12 + lhs.m31 * rhs.m13)), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + (lhs.m22 * rhs.m12 + lhs.m32 * rhs.m13)), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + (lhs.m23 * rhs.m12 + lhs.m33 * rhs.m13)), ((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + (lhs.m20 * rhs.m22 + lhs.m30 * rhs.m23)), ((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + (lhs.m21 * rhs.m22 + lhs.m31 * rhs.m23)), ((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + (lhs.m22 * rhs.m22 + lhs.m32 * rhs.m23)), ((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + (lhs.m23 * rhs.m22 + lhs.m33 * rhs.m23)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication dmat4 * dmat4 -> dmat4.
        /// </summary>
        public static dmat4 operator*(dmat4 lhs, dmat4 rhs) => new dmat4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + (lhs.m20 * rhs.m02 + lhs.m30 * rhs.m03)), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + (lhs.m21 * rhs.m02 + lhs.m31 * rhs.m03)), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + (lhs.m22 * rhs.m02 + lhs.m32 * rhs.m03)), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + (lhs.m23 * rhs.m02 + lhs.m33 * rhs.m03)), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + (lhs.m20 * rhs.m12 + lhs.m30 * rhs.m13)), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + (lhs.m21 * rhs.m12 + lhs.m31 * rhs.m13)), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + (lhs.m22 * rhs.m12 + lhs.m32 * rhs.m13)), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + (lhs.m23 * rhs.m12 + lhs.m33 * rhs.m13)), ((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + (lhs.m20 * rhs.m22 + lhs.m30 * rhs.m23)), ((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + (lhs.m21 * rhs.m22 + lhs.m31 * rhs.m23)), ((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + (lhs.m22 * rhs.m22 + lhs.m32 * rhs.m23)), ((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + (lhs.m23 * rhs.m22 + lhs.m33 * rhs.m23)), ((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + (lhs.m20 * rhs.m32 + lhs.m30 * rhs.m33)), ((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + (lhs.m21 * rhs.m32 + lhs.m31 * rhs.m33)), ((lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31) + (lhs.m22 * rhs.m32 + lhs.m32 * rhs.m33)), ((lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31) + (lhs.m23 * rhs.m32 + lhs.m33 * rhs.m33)));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static dvec4 operator*(dmat4 m, dvec4 v) => new dvec4(((m.m00 * v.x + m.m10 * v.y) + (m.m20 * v.z + m.m30 * v.w)), ((m.m01 * v.x + m.m11 * v.y) + (m.m21 * v.z + m.m31 * v.w)), ((m.m02 * v.x + m.m12 * v.y) + (m.m22 * v.z + m.m32 * v.w)), ((m.m03 * v.x + m.m13 * v.y) + (m.m23 * v.z + m.m33 * v.w)));
        
        /// <summary>
        /// Executes a matrix-matrix-divison A / B == A * B^-1 (use with caution).
        /// </summary>
        public static dmat4 operator/(dmat4 A, dmat4 B) => A * B.Inverse;
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static dmat4 CompMul(dmat4 A, dmat4 B) => new dmat4(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m03 * B.m03, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12, A.m13 * B.m13, A.m20 * B.m20, A.m21 * B.m21, A.m22 * B.m22, A.m23 * B.m23, A.m30 * B.m30, A.m31 * B.m31, A.m32 * B.m32, A.m33 * B.m33);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static dmat4 CompDiv(dmat4 A, dmat4 B) => new dmat4(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m03 / B.m03, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12, A.m13 / B.m13, A.m20 / B.m20, A.m21 / B.m21, A.m22 / B.m22, A.m23 / B.m23, A.m30 / B.m30, A.m31 / B.m31, A.m32 / B.m32, A.m33 / B.m33);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static dmat4 CompAdd(dmat4 A, dmat4 B) => new dmat4(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m03 + B.m03, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12, A.m13 + B.m13, A.m20 + B.m20, A.m21 + B.m21, A.m22 + B.m22, A.m23 + B.m23, A.m30 + B.m30, A.m31 + B.m31, A.m32 + B.m32, A.m33 + B.m33);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static dmat4 CompSub(dmat4 A, dmat4 B) => new dmat4(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m03 - B.m03, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12, A.m13 - B.m13, A.m20 - B.m20, A.m21 - B.m21, A.m22 - B.m22, A.m23 - B.m23, A.m30 - B.m30, A.m31 - B.m31, A.m32 - B.m32, A.m33 - B.m33);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static dmat4 operator+(dmat4 lhs, dmat4 rhs) => new dmat4(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m03 + rhs.m03, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13, lhs.m20 + rhs.m20, lhs.m21 + rhs.m21, lhs.m22 + rhs.m22, lhs.m23 + rhs.m23, lhs.m30 + rhs.m30, lhs.m31 + rhs.m31, lhs.m32 + rhs.m32, lhs.m33 + rhs.m33);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static dmat4 operator+(dmat4 lhs, double rhs) => new dmat4(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m03 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m13 + rhs, lhs.m20 + rhs, lhs.m21 + rhs, lhs.m22 + rhs, lhs.m23 + rhs, lhs.m30 + rhs, lhs.m31 + rhs, lhs.m32 + rhs, lhs.m33 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static dmat4 operator+(double lhs, dmat4 rhs) => new dmat4(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m03, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m13, lhs + rhs.m20, lhs + rhs.m21, lhs + rhs.m22, lhs + rhs.m23, lhs + rhs.m30, lhs + rhs.m31, lhs + rhs.m32, lhs + rhs.m33);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static dmat4 operator-(dmat4 lhs, dmat4 rhs) => new dmat4(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m03 - rhs.m03, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13, lhs.m20 - rhs.m20, lhs.m21 - rhs.m21, lhs.m22 - rhs.m22, lhs.m23 - rhs.m23, lhs.m30 - rhs.m30, lhs.m31 - rhs.m31, lhs.m32 - rhs.m32, lhs.m33 - rhs.m33);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static dmat4 operator-(dmat4 lhs, double rhs) => new dmat4(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m03 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m13 - rhs, lhs.m20 - rhs, lhs.m21 - rhs, lhs.m22 - rhs, lhs.m23 - rhs, lhs.m30 - rhs, lhs.m31 - rhs, lhs.m32 - rhs, lhs.m33 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static dmat4 operator-(double lhs, dmat4 rhs) => new dmat4(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m03, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m13, lhs - rhs.m20, lhs - rhs.m21, lhs - rhs.m22, lhs - rhs.m23, lhs - rhs.m30, lhs - rhs.m31, lhs - rhs.m32, lhs - rhs.m33);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static dmat4 operator/(dmat4 lhs, double rhs) => new dmat4(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m03 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs, lhs.m13 / rhs, lhs.m20 / rhs, lhs.m21 / rhs, lhs.m22 / rhs, lhs.m23 / rhs, lhs.m30 / rhs, lhs.m31 / rhs, lhs.m32 / rhs, lhs.m33 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static dmat4 operator/(double lhs, dmat4 rhs) => new dmat4(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m03, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12, lhs / rhs.m13, lhs / rhs.m20, lhs / rhs.m21, lhs / rhs.m22, lhs / rhs.m23, lhs / rhs.m30, lhs / rhs.m31, lhs / rhs.m32, lhs / rhs.m33);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static dmat4 operator*(dmat4 lhs, double rhs) => new dmat4(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m03 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs, lhs.m13 * rhs, lhs.m20 * rhs, lhs.m21 * rhs, lhs.m22 * rhs, lhs.m23 * rhs, lhs.m30 * rhs, lhs.m31 * rhs, lhs.m32 * rhs, lhs.m33 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static dmat4 operator*(double lhs, dmat4 rhs) => new dmat4(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m03, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12, lhs * rhs.m13, lhs * rhs.m20, lhs * rhs.m21, lhs * rhs.m22, lhs * rhs.m23, lhs * rhs.m30, lhs * rhs.m31, lhs * rhs.m32, lhs * rhs.m33);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat4 operator<(dmat4 lhs, dmat4 rhs) => new bmat4(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m02 < rhs.m02, lhs.m03 < rhs.m03, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11, lhs.m12 < rhs.m12, lhs.m13 < rhs.m13, lhs.m20 < rhs.m20, lhs.m21 < rhs.m21, lhs.m22 < rhs.m22, lhs.m23 < rhs.m23, lhs.m30 < rhs.m30, lhs.m31 < rhs.m31, lhs.m32 < rhs.m32, lhs.m33 < rhs.m33);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat4 operator<(dmat4 lhs, double rhs) => new bmat4(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m02 < rhs, lhs.m03 < rhs, lhs.m10 < rhs, lhs.m11 < rhs, lhs.m12 < rhs, lhs.m13 < rhs, lhs.m20 < rhs, lhs.m21 < rhs, lhs.m22 < rhs, lhs.m23 < rhs, lhs.m30 < rhs, lhs.m31 < rhs, lhs.m32 < rhs, lhs.m33 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat4 operator<(double lhs, dmat4 rhs) => new bmat4(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m02, lhs < rhs.m03, lhs < rhs.m10, lhs < rhs.m11, lhs < rhs.m12, lhs < rhs.m13, lhs < rhs.m20, lhs < rhs.m21, lhs < rhs.m22, lhs < rhs.m23, lhs < rhs.m30, lhs < rhs.m31, lhs < rhs.m32, lhs < rhs.m33);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat4 operator<=(dmat4 lhs, dmat4 rhs) => new bmat4(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m02 <= rhs.m02, lhs.m03 <= rhs.m03, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11, lhs.m12 <= rhs.m12, lhs.m13 <= rhs.m13, lhs.m20 <= rhs.m20, lhs.m21 <= rhs.m21, lhs.m22 <= rhs.m22, lhs.m23 <= rhs.m23, lhs.m30 <= rhs.m30, lhs.m31 <= rhs.m31, lhs.m32 <= rhs.m32, lhs.m33 <= rhs.m33);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat4 operator<=(dmat4 lhs, double rhs) => new bmat4(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m02 <= rhs, lhs.m03 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs, lhs.m12 <= rhs, lhs.m13 <= rhs, lhs.m20 <= rhs, lhs.m21 <= rhs, lhs.m22 <= rhs, lhs.m23 <= rhs, lhs.m30 <= rhs, lhs.m31 <= rhs, lhs.m32 <= rhs, lhs.m33 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat4 operator<=(double lhs, dmat4 rhs) => new bmat4(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m02, lhs <= rhs.m03, lhs <= rhs.m10, lhs <= rhs.m11, lhs <= rhs.m12, lhs <= rhs.m13, lhs <= rhs.m20, lhs <= rhs.m21, lhs <= rhs.m22, lhs <= rhs.m23, lhs <= rhs.m30, lhs <= rhs.m31, lhs <= rhs.m32, lhs <= rhs.m33);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat4 operator>(dmat4 lhs, dmat4 rhs) => new bmat4(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m02 > rhs.m02, lhs.m03 > rhs.m03, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11, lhs.m12 > rhs.m12, lhs.m13 > rhs.m13, lhs.m20 > rhs.m20, lhs.m21 > rhs.m21, lhs.m22 > rhs.m22, lhs.m23 > rhs.m23, lhs.m30 > rhs.m30, lhs.m31 > rhs.m31, lhs.m32 > rhs.m32, lhs.m33 > rhs.m33);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat4 operator>(dmat4 lhs, double rhs) => new bmat4(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m02 > rhs, lhs.m03 > rhs, lhs.m10 > rhs, lhs.m11 > rhs, lhs.m12 > rhs, lhs.m13 > rhs, lhs.m20 > rhs, lhs.m21 > rhs, lhs.m22 > rhs, lhs.m23 > rhs, lhs.m30 > rhs, lhs.m31 > rhs, lhs.m32 > rhs, lhs.m33 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat4 operator>(double lhs, dmat4 rhs) => new bmat4(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m02, lhs > rhs.m03, lhs > rhs.m10, lhs > rhs.m11, lhs > rhs.m12, lhs > rhs.m13, lhs > rhs.m20, lhs > rhs.m21, lhs > rhs.m22, lhs > rhs.m23, lhs > rhs.m30, lhs > rhs.m31, lhs > rhs.m32, lhs > rhs.m33);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat4 operator>=(dmat4 lhs, dmat4 rhs) => new bmat4(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m02 >= rhs.m02, lhs.m03 >= rhs.m03, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11, lhs.m12 >= rhs.m12, lhs.m13 >= rhs.m13, lhs.m20 >= rhs.m20, lhs.m21 >= rhs.m21, lhs.m22 >= rhs.m22, lhs.m23 >= rhs.m23, lhs.m30 >= rhs.m30, lhs.m31 >= rhs.m31, lhs.m32 >= rhs.m32, lhs.m33 >= rhs.m33);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat4 operator>=(dmat4 lhs, double rhs) => new bmat4(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m02 >= rhs, lhs.m03 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs, lhs.m12 >= rhs, lhs.m13 >= rhs, lhs.m20 >= rhs, lhs.m21 >= rhs, lhs.m22 >= rhs, lhs.m23 >= rhs, lhs.m30 >= rhs, lhs.m31 >= rhs, lhs.m32 >= rhs, lhs.m33 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat4 operator>=(double lhs, dmat4 rhs) => new bmat4(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m02, lhs >= rhs.m03, lhs >= rhs.m10, lhs >= rhs.m11, lhs >= rhs.m12, lhs >= rhs.m13, lhs >= rhs.m20, lhs >= rhs.m21, lhs >= rhs.m22, lhs >= rhs.m23, lhs >= rhs.m30, lhs >= rhs.m31, lhs >= rhs.m32, lhs >= rhs.m33);
        
        /// <summary>
        /// Creates a frustrum projection matrix.
        /// </summary>
        public static dmat4 Frustum(double left, double right, double bottom, double top, double nearVal, double farVal)
        {
            var m = Identity;
            m.m00 = (2 * nearVal) / (right - left);
            m.m11 = (2 * nearVal) / (top - bottom);
            m.m20 = (right + left) / (right - left);
            m.m21 = (top + bottom) / (top - bottom);
            m.m22 = -(farVal + nearVal) / (farVal - nearVal);
            m.m23 = -1;
            m.m32 = -(2 * farVal * nearVal) / (farVal - nearVal);
            return m;
        }
        
        /// <summary>
        /// Creates a matrix for a symmetric perspective-view frustum with far plane at infinite.
        /// </summary>
        public static dmat4 InfinitePerspective(double fovy, double aspect, double zNear)
        {
            var range = Math.Tan((double)fovy / 2.0) * (double)zNear;
            var l = -range * (double)aspect;
            var r = range * (double)aspect;
            var b = -range;
            var t = range;
            var m = Identity;
            m.m00 = (double)( ((2.0)*(double)zNear)/(r - l) );
            m.m11 = (double)( ((2.0)*(double)zNear)/(t - b) );
            m.m22 = (double)( - (1.0) );
            m.m23 = (double)( - (1.0) );
            m.m32 = (double)( - (2.0)*(double)zNear );
            return m;
        }
        
        /// <summary>
        /// Build a look at view matrix.
        /// </summary>
        public static dmat4 LookAt(dvec3 eye, dvec3 center, dvec3 up)
        {
            var f = (center - eye).Normalized;
            var s = dvec3.Cross(f, up).Normalized;
            var u = dvec3.Cross(s, f);
            var m = Identity;
            m.m00 = s.x;
            m.m10 = s.y;
            m.m20 = s.z;
            m.m01 = u.x;
            m.m11 = u.y;
            m.m21 = u.z;
            m.m02 = -f.x;
            m.m12 = -f.y;
            m.m22 = -f.z;
            m.m30 = -dvec3.Dot(s, eye);
            m.m31 = -dvec3.Dot(u, eye);
            m.m32 = dvec3.Dot(f, eye);
            return m;
        }
        
        /// <summary>
        /// Creates a matrix for an orthographic parallel viewing volume.
        /// </summary>
        public static dmat4 Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
        {
            var m = Identity;
            m.m00 = 2/(right - left);
            m.m11 = 2/(top - bottom);
            m.m22 = - 2/(zFar - zNear);
            m.m30 = - (right + left)/(right - left);
            m.m31 = - (top + bottom)/(top - bottom);
            m.m32 = - (zFar + zNear)/(zFar - zNear);
            return m;
        }
        
        /// <summary>
        /// Creates a matrix for projecting two-dimensional coordinates onto the screen.
        /// </summary>
        public static dmat4 Ortho(double left, double right, double bottom, double top)
        {
            var m = Identity;
            m.m00 = 2/(right - left);
            m.m11 = 2/(top - bottom);
            m.m22 = - 1;
            m.m30 = - (right + left)/(right - left);
            m.m31 = - (top + bottom)/(top - bottom);
            return m;
        }
        
        /// <summary>
        /// Creates a perspective transformation matrix.
        /// </summary>
        public static dmat4 Perspective(double fovy, double aspect, double zNear, double zFar)
        {
            var tanHalfFovy = Math.Tan((double)fovy / 2.0);
            var m = Zero;
            m.m00 = (double)( 1 / ((double)aspect * tanHalfFovy) );
            m.m11 = (double)( 1 / (tanHalfFovy) );
            m.m22 = (double)( -(zFar + zNear) / (zFar - zNear) );
            m.m23 = (double)( -1 );
            m.m32 = (double)( -(2 * zFar * zNear) / (zFar - zNear) );
            return m;
        }
        
        /// <summary>
        /// Builds a perspective projection matrix based on a field of view.
        /// </summary>
        public static dmat4 PerspectiveFov(double fov, double width, double height, double zNear, double zFar)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException("width");
            if (height <= 0) throw new ArgumentOutOfRangeException("height");
            if (fov <= 0) throw new ArgumentOutOfRangeException("fov");
            var h = Math.Cos((double)fov / 2.0) / Math.Sin((double)fov / 2.0);
            var w = h * (double)(height / width);
            var m = Zero;
            m.m00 = (double)w;
            m.m11 = (double)h;
            m.m22 = - (zFar + zNear)/(zFar - zNear);
            m.m23 = - 1;
            m.m32 = - (2*zFar*zNear)/(zFar - zNear);
            return m;
        }
        
        /// <summary>
        /// Map the specified object coordinates (obj.x, obj.y, obj.z) into window coordinates.
        /// </summary>
        public static dvec3 Project(dvec3 obj, dmat4 model, dmat4 proj, dvec4 viewport)
        {
            var tmp = proj * (model * new dvec4(obj, 1));
            tmp /= tmp.w;
            tmp = tmp * 0.5d + 0.5d;
            tmp.x = tmp.x * viewport.z + viewport.x;
            tmp.y = tmp.y * viewport.w + viewport.y;
            return tmp.swizzle.xyz;
        }
        
        /// <summary>
        /// Map the specified window coordinates (win.x, win.y, win.z) into object coordinates.
        /// </summary>
        public static dvec3 UnProject(dvec3 win, dmat4 model, dmat4 proj, dvec4 viewport)
        {
            var tmp = new dvec4(win, 1);
            tmp.x = (tmp.x - viewport.x) / viewport.z;
            tmp.y = (tmp.y - viewport.y) / viewport.w;
            tmp = tmp * 2 - 1;
        
            var unp = proj.Inverse * tmp;
            unp /= unp.w;
            var obj = model.Inverse * unp;
            return (dvec3)obj / obj.w;
        }
        
        /// <summary>
        /// Map the specified window coordinates (win.x, win.y, win.z) into object coordinates (faster but less precise).
        /// </summary>
        public static dvec3 UnProjectFaster(dvec3 win, dmat4 model, dmat4 proj, dvec4 viewport)
        {
            var tmp = new dvec4(win, 1);
            tmp.x = (tmp.x - viewport.x) / viewport.z;
            tmp.y = (tmp.y - viewport.y) / viewport.w;
            tmp = tmp * 2 - 1;
        
            var obj = (proj * model).Inverse * tmp;
            return (dvec3)obj / obj.w;
        }
        
        /// <summary>
        /// Builds a rotation 4 * 4 matrix created from an axis vector and an angle in radians.
        /// </summary>
        public static dmat4 Rotate(double angle, dvec3 v)
        {
            var c = (double)Math.Cos((double)angle);
            var s = (double)Math.Sin((double)angle);
        
            var axis = v.Normalized;
            var temp = (1 - c) * axis;
        
            var m = Identity;
            m.m00 = c + temp.x * axis.x;
            m.m01 = 0 + temp.x * axis.y + s * axis.z;
            m.m02 = 0 + temp.x * axis.z - s * axis.y;
        
            m.m10 = 0 + temp.y * axis.x - s * axis.z;
            m.m11 = c + temp.y * axis.y;
            m.m12 = 0 + temp.y * axis.z + s * axis.x;
        
            m.m20 = 0 + temp.z * axis.x + s * axis.y;
            m.m21 = 0 + temp.z * axis.y - s * axis.x;
            m.m22 = c + temp.z * axis.z;
            return m;
        }
        
        /// <summary>
        /// Builds a rotation matrix around UnitX and an angle in radians.
        /// </summary>
        public static dmat4 RotateX(double angle)
        {
            return Rotate(angle, dvec3.UnitX);
        }
        
        /// <summary>
        /// Builds a rotation matrix around UnitY and an angle in radians.
        /// </summary>
        public static dmat4 RotateY(double angle)
        {
            return Rotate(angle, dvec3.UnitY);
        }
        
        /// <summary>
        /// Builds a rotation matrix around UnitZ and an angle in radians.
        /// </summary>
        public static dmat4 RotateZ(double angle)
        {
            return Rotate(angle, dvec3.UnitZ);
        }
        
        /// <summary>
        /// Builds a scale matrix by components x, y, z.
        /// </summary>
        public static dmat4 Scale(double x, double y, double z)
        {
            var m = Identity;
            m.m00 = x;
            m.m11 = y;
            m.m22 = z;
            return m;
        }
        
        /// <summary>
        /// Builds a scale matrix by vector v.
        /// </summary>
        public static dmat4 Scale(dvec3 v) => Scale(v.x, v.y, v.z);
        
        /// <summary>
        /// Builds a scale matrix by uniform scaling s.
        /// </summary>
        public static dmat4 Scale(double s) => Scale(s, s, s);
        
        /// <summary>
        /// Builds a translation matrix by components x, y, z.
        /// </summary>
        public static dmat4 Translate(double x, double y, double z)
        {
            var m = Identity;
            m.m30 = x;
            m.m31 = y;
            m.m32 = z;
            return m;
        }
        
        /// <summary>
        /// Builds a translation matrix by vector v.
        /// </summary>
        public static dmat4 Translate(dvec3 v) => Translate(v.x, v.y, v.z);
    }
}
