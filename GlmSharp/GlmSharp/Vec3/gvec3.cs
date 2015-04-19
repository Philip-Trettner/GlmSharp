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
    /// A vector of type T with 3 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct gvec3<T> : IReadOnlyList<T>, IEquatable<gvec3<T>>
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gvec3(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public gvec3(T v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public gvec3(gvec2<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public gvec3(gvec2<T> v, T z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public gvec3(gvec3<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public gvec3(gvec4<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec3(IReadOnlyList<T> v)
        {
            var c = v.Count;
            this.x = c < 0 ? default(T) : v[0];
            this.y = c < 1 ? default(T) : v[1];
            this.z = c < 2 ? default(T) : v[2];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec3(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? default(T) : (T)v[0];
            this.y = c < 1 ? default(T) : (T)v[1];
            this.z = c < 2 ? default(T) : (T)v[2];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec3(T[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? default(T) : v[0];
            this.y = c < 1 ? default(T) : v[1];
            this.z = c < 2 ? default(T) : v[2];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec3(T[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? default(T) : v[0 + startIndex];
            this.y = c + startIndex < 1 ? default(T) : v[1 + startIndex];
            this.z = c + startIndex < 2 ? default(T) : v[2 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec3(IEnumerable<T> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a gvec2.
        /// </summary>
        public static explicit operator gvec2<T>(gvec3<T> v) => new gvec2<T>((T)v.x, (T)v.y);
        
        /// <summary>
        /// Explicitly converts this to a gvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator gvec4<T>(gvec3<T> v) => new gvec4<T>((T)v.x, (T)v.y, (T)v.z, default(T));
        
        /// <summary>
        /// Explicitly converts this to a T array.
        /// </summary>
        public static explicit operator T[](gvec3<T> v) => new [] { v.x, v.y, v.z };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](gvec3<T> v) => new Object[] { v.x, v.y, v.z };

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
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_gvec3<T> swizzle => new swizzle_gvec3<T>(x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> xy
        {
            get
            {
                return new gvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> xz
        {
            get
            {
                return new gvec2<T>(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> yz
        {
            get
            {
                return new gvec2<T>(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> xyz
        {
            get
            {
                return new gvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> rg
        {
            get
            {
                return new gvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> rb
        {
            get
            {
                return new gvec2<T>(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> gb
        {
            get
            {
                return new gvec2<T>(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> rgb
        {
            get
            {
                return new gvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public T r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public T g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public T b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public T[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static gvec3<T> Zero { get; } = new gvec3<T>(default(T), default(T), default(T));

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(gvec3<T> lhs, gvec3<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(gvec3<T> lhs, gvec3<T> rhs) => !lhs.Equals(rhs);

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
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => ((x + sep + y) + sep + z);
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(gvec3<T> rhs) => ((EqualityComparer<T>.Default.Equals(x, rhs.x) && EqualityComparer<T>.Default.Equals(y, rhs.y)) && EqualityComparer<T>.Default.Equals(z, rhs.z));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gvec3<T> && Equals((gvec3<T>) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((EqualityComparer<T>.Default.GetHashCode(x)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(y)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(z);
            }
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec3 Equal(gvec3<T> lhs, gvec3<T> rhs) => new bvec3(EqualityComparer<T>.Default.Equals(lhs.x, rhs.x), EqualityComparer<T>.Default.Equals(lhs.y, rhs.y), EqualityComparer<T>.Default.Equals(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec3 Equal(gvec3<T> lhs, T rhs) => new bvec3(EqualityComparer<T>.Default.Equals(lhs.x, rhs), EqualityComparer<T>.Default.Equals(lhs.y, rhs), EqualityComparer<T>.Default.Equals(lhs.z, rhs));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec3 Equal(T lhs, gvec3<T> rhs) => new bvec3(EqualityComparer<T>.Default.Equals(lhs, rhs.x), EqualityComparer<T>.Default.Equals(lhs, rhs.y), EqualityComparer<T>.Default.Equals(lhs, rhs.z));
        
        /// <summary>
        /// Returns a bvec from the application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec3 Equal(T lhs, T rhs) => new bvec3(EqualityComparer<T>.Default.Equals(lhs, rhs));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec3 NotEqual(gvec3<T> lhs, gvec3<T> rhs) => new bvec3(!EqualityComparer<T>.Default.Equals(lhs.x, rhs.x), !EqualityComparer<T>.Default.Equals(lhs.y, rhs.y), !EqualityComparer<T>.Default.Equals(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec3 NotEqual(gvec3<T> lhs, T rhs) => new bvec3(!EqualityComparer<T>.Default.Equals(lhs.x, rhs), !EqualityComparer<T>.Default.Equals(lhs.y, rhs), !EqualityComparer<T>.Default.Equals(lhs.z, rhs));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec3 NotEqual(T lhs, gvec3<T> rhs) => new bvec3(!EqualityComparer<T>.Default.Equals(lhs, rhs.x), !EqualityComparer<T>.Default.Equals(lhs, rhs.y), !EqualityComparer<T>.Default.Equals(lhs, rhs.z));
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec3 NotEqual(T lhs, T rhs) => new bvec3(!EqualityComparer<T>.Default.Equals(lhs, rhs));

        #endregion

    }
}
