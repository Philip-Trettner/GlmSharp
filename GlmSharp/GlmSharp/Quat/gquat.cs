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
    /// A quaternion of type T.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct gquat<T> : IReadOnlyList<T>, IEquatable<gquat<T>>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public T x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public T y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public T z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public T w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gquat(T x, T y, T z, T w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public gquat(T v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// copy constructor
        /// </summary>
        public gquat(gquat<T> q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)
        /// </summary>
        public gquat(gvec3<T> v, T s)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = s;
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a gvec4.
        /// </summary>
        public static explicit operator gvec4<T>(gquat<T> v) => new gvec4<T>((T)v.x, (T)v.y, (T)v.z, (T)v.w);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public T this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public T[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero quaternion
        /// </summary>
        public static gquat<T> Zero { get; } = new gquat<T>(default(T), default(T), default(T), default(T));

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(gquat<T> lhs, gquat<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(gquat<T> lhs, gquat<T> rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
            yield return w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public string ToString(string sep) => ((x + sep + y) + sep + (z + sep + w));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(gquat<T> rhs) => ((EqualityComparer<T>.Default.Equals(x, rhs.x) && EqualityComparer<T>.Default.Equals(y, rhs.y)) && (EqualityComparer<T>.Default.Equals(z, rhs.z) && EqualityComparer<T>.Default.Equals(w, rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gquat<T> && Equals((gquat<T>) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((EqualityComparer<T>.Default.GetHashCode(x)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(y)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(z)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(w);
            }
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec4 Equal(gquat<T> lhs, gquat<T> rhs) => new bvec4(EqualityComparer<T>.Default.Equals(lhs.x, rhs.x), EqualityComparer<T>.Default.Equals(lhs.y, rhs.y), EqualityComparer<T>.Default.Equals(lhs.z, rhs.z), EqualityComparer<T>.Default.Equals(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec4 Equal(gquat<T> lhs, T rhs) => new bvec4(EqualityComparer<T>.Default.Equals(lhs.x, rhs), EqualityComparer<T>.Default.Equals(lhs.y, rhs), EqualityComparer<T>.Default.Equals(lhs.z, rhs), EqualityComparer<T>.Default.Equals(lhs.w, rhs));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec4 Equal(T lhs, gquat<T> rhs) => new bvec4(EqualityComparer<T>.Default.Equals(lhs, rhs.x), EqualityComparer<T>.Default.Equals(lhs, rhs.y), EqualityComparer<T>.Default.Equals(lhs, rhs.z), EqualityComparer<T>.Default.Equals(lhs, rhs.w));
        
        /// <summary>
        /// Returns a bvec from the application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec4 Equal(T lhs, T rhs) => new bvec4(EqualityComparer<T>.Default.Equals(lhs, rhs));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec4 NotEqual(gquat<T> lhs, gquat<T> rhs) => new bvec4(!EqualityComparer<T>.Default.Equals(lhs.x, rhs.x), !EqualityComparer<T>.Default.Equals(lhs.y, rhs.y), !EqualityComparer<T>.Default.Equals(lhs.z, rhs.z), !EqualityComparer<T>.Default.Equals(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec4 NotEqual(gquat<T> lhs, T rhs) => new bvec4(!EqualityComparer<T>.Default.Equals(lhs.x, rhs), !EqualityComparer<T>.Default.Equals(lhs.y, rhs), !EqualityComparer<T>.Default.Equals(lhs.z, rhs), !EqualityComparer<T>.Default.Equals(lhs.w, rhs));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec4 NotEqual(T lhs, gquat<T> rhs) => new bvec4(!EqualityComparer<T>.Default.Equals(lhs, rhs.x), !EqualityComparer<T>.Default.Equals(lhs, rhs.y), !EqualityComparer<T>.Default.Equals(lhs, rhs.z), !EqualityComparer<T>.Default.Equals(lhs, rhs.w));
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec4 NotEqual(T lhs, T rhs) => new bvec4(!EqualityComparer<T>.Default.Equals(lhs, rhs));

        #endregion

    }
}
