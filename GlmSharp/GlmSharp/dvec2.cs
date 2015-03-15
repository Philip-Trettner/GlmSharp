using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct dvec2 : IReadOnlyList<double>, IEquatable<dvec2>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public double y;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_dvec2 swizzle => new swizzle_dvec2(x, y);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly dvec2 Zero = new dvec2(default(double), default(double));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly dvec2 Ones = new dvec2(1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly dvec2 UnitX = new dvec2(1.0, default(double));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly dvec2 UnitY = new dvec2(default(double), 1.0);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public double[] Values => new[] { x, y };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public dvec2(double v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec2(dvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec2(dvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec2(dvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
        {
            yield return x;
            yield return y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(dvec2 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is dvec2 && Equals((dvec2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(dvec2 lhs, dvec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(dvec2 lhs, dvec2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((x.GetHashCode()) * 397) ^ y.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public double MinElement => Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public double MaxElement => Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => x*x + y*y;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => Math.Abs(x) + Math.Abs(y);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => Math.Max(Math.Abs(x), Math.Abs(y));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow(Math.Abs(x), p) + Math.Pow(Math.Abs(y), p), 1 / p);
    }
}
