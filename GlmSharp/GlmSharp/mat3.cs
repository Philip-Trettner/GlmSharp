using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct mat3 : IEnumerable<float>, IEquatable<mat3>
    {
        // Matrix fields mXY
        public float m00, m01, m02; // Column 0
        public float m10, m11, m12; // Column 1
        public float m20, m21, m22; // Column 2
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public float[,] Values => new[,] { { m00, m01, m02 }, { m10, m11, m12 }, { m20, m21, m22 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public float[] Values1D => new[] { m00, m01, m02, m10, m11, m12, m20, m21, m22 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public vec3 Column0 => new vec3(m00, m01, m02);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public vec3 Column1 => new vec3(m10, m11, m12);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public vec3 Column2 => new vec3(m20, m21, m22);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public vec3 Row0 => new vec3(m00, m10, m20);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public vec3 Row1 => new vec3(m01, m11, m21);
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public vec3 Row2 => new vec3(m02, m12, m22);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly mat3 Zero = new mat3(default(float), default(float), default(float), default(float), default(float), default(float), default(float), default(float), default(float));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly mat3 Ones = new mat3(1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly mat3 Identity = new mat3(1f, default(float), default(float), default(float), 1f, default(float), default(float), default(float), 1f);
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public mat3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
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
        /// Copy constructor
        /// </summary>
        public mat3(mat3 m)
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
        /// Column constructor
        /// </summary>
        public mat3(vec3 c0, vec3 c1, vec3 c2)
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
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<float> GetEnumerator()
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
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(mat3 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m02.Equals(rhs.m02) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m12.Equals(rhs.m12) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21) && m22.Equals(rhs.m22);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is mat3 && Equals((mat3) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(mat3 lhs, mat3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(mat3 lhs, mat3 rhs) => !lhs.Equals(rhs);
        
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
    }
}
