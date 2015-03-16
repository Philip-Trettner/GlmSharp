using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct dmat4x2 : IEnumerable<double>, IEquatable<dmat4x2>
    {
        // Matrix fields mXY
        public double m00, m01; // Column 0
        public double m10, m11; // Column 1
        public double m20, m21; // Column 2
        public double m30, m31; // Column 3
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public double[,] Values => new[,] { { m00, m01 }, { m10, m11 }, { m20, m21 }, { m30, m31 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public double[] Values1D => new[] { m00, m01, m10, m11, m20, m21, m30, m31 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public dvec2 Column0 => new dvec2(m00, m01);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public dvec2 Column1 => new dvec2(m10, m11);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public dvec2 Column2 => new dvec2(m20, m21);
        
        /// <summary>
        /// Returns the column nr 3
        /// </summary>
        public dvec2 Column3 => new dvec2(m30, m31);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public dvec4 Row0 => new dvec4(m00, m10, m20, m30);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public dvec4 Row1 => new dvec4(m01, m11, m21, m31);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly dmat4x2 Zero = new dmat4x2(default(double), default(double), default(double), default(double), default(double), default(double), default(double), default(double));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly dmat4x2 Ones = new dmat4x2(1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly dmat4x2 Identity = new dmat4x2(1.0, default(double), default(double), 1.0, default(double), default(double), default(double), default(double));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dmat4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m10 = m10;
            this.m11 = m11;
            this.m20 = m20;
            this.m21 = m21;
            this.m30 = m30;
            this.m31 = m31;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public dmat4x2(dmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public dmat4x2(dvec2 c0, dvec2 c1, dvec2 c2, dvec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m30 = c3.x;
            this.m31 = c3.y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m10;
            yield return m11;
            yield return m20;
            yield return m21;
            yield return m30;
            yield return m31;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(dmat4x2 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21) && m30.Equals(rhs.m30) && m31.Equals(rhs.m31);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is dmat4x2 && Equals((dmat4x2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(dmat4x2 lhs, dmat4x2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(dmat4x2 lhs, dmat4x2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m30.GetHashCode()) * 397) ^ m31.GetHashCode();
            }
        }
    }
}
