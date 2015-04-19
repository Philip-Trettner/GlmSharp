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
    /// A vector of type long with 4 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct lvec4 : IReadOnlyList<long>, IEquatable<lvec4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public long x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public long y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public long z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public long w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public lvec4(long x, long y, long z, long w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public lvec4(long v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public lvec4(lvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0;
            this.w = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public lvec4(lvec2 v, long z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public lvec4(lvec2 v, long z, long w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public lvec4(lvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public lvec4(lvec3 v, long w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public lvec4(lvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public lvec4(IReadOnlyList<long> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0 : v[0];
            this.y = c < 1 ? 0 : v[1];
            this.z = c < 2 ? 0 : v[2];
            this.w = c < 3 ? 0 : v[3];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public lvec4(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0 : (long)v[0];
            this.y = c < 1 ? 0 : (long)v[1];
            this.z = c < 2 ? 0 : (long)v[2];
            this.w = c < 3 ? 0 : (long)v[3];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public lvec4(long[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0 : v[0];
            this.y = c < 1 ? 0 : v[1];
            this.z = c < 2 ? 0 : v[2];
            this.w = c < 3 ? 0 : v[3];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public lvec4(long[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0 : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0 : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0 : v[3 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public lvec4(IEnumerable<long> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a decvec4.
        /// </summary>
        public static implicit operator decvec4(lvec4 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(lvec4 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(lvec4 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(lvec4 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(lvec4 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(lvec4 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(lvec4 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(lvec4 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(lvec4 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(lvec4 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(lvec4 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(lvec4 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(lvec4 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(lvec4 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(lvec4 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(lvec4 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(lvec4 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(lvec4 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(lvec4 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(lvec4 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(lvec4 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(lvec4 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(lvec4 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(lvec4 v) => new bvec2(v.x != 0, v.y != 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(lvec4 v) => new bvec3(v.x != 0, v.y != 0, v.z != 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(lvec4 v) => new bvec4(v.x != 0, v.y != 0, v.z != 0, v.w != 0);
        
        /// <summary>
        /// Explicitly converts this to a long array.
        /// </summary>
        public static explicit operator long[](lvec4 v) => new [] { v.x, v.y, v.z, v.w };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](lvec4 v) => new Object[] { v.x, v.y, v.z, v.w };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public long this[int index]
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
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_lvec4 swizzle => new swizzle_lvec4(x, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec2 xy
        {
            get
            {
                return new lvec2(x, y);
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
        public lvec2 xz
        {
            get
            {
                return new lvec2(x, z);
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
        public lvec2 yz
        {
            get
            {
                return new lvec2(y, z);
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
        public lvec3 xyz
        {
            get
            {
                return new lvec3(x, y, z);
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
        public lvec2 xw
        {
            get
            {
                return new lvec2(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec2 yw
        {
            get
            {
                return new lvec2(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec3 xyw
        {
            get
            {
                return new lvec3(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec2 zw
        {
            get
            {
                return new lvec2(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec3 xzw
        {
            get
            {
                return new lvec3(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec3 yzw
        {
            get
            {
                return new lvec3(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec4 xyzw
        {
            get
            {
                return new lvec4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec2 rg
        {
            get
            {
                return new lvec2(x, y);
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
        public lvec2 rb
        {
            get
            {
                return new lvec2(x, z);
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
        public lvec2 gb
        {
            get
            {
                return new lvec2(y, z);
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
        public lvec3 rgb
        {
            get
            {
                return new lvec3(x, y, z);
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
        public lvec2 ra
        {
            get
            {
                return new lvec2(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec2 ga
        {
            get
            {
                return new lvec2(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec3 rga
        {
            get
            {
                return new lvec3(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec2 ba
        {
            get
            {
                return new lvec2(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec3 rba
        {
            get
            {
                return new lvec3(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec3 gba
        {
            get
            {
                return new lvec3(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public lvec4 rgba
        {
            get
            {
                return new lvec4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long r
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
        public long g
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
        public long b
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
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public long[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public long MinElement => Math.Min(Math.Min(x, y), Math.Min(z, w));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public long MaxElement => Math.Max(Math.Max(x, y), Math.Max(z, w));
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => ((x*x + y*y) + (z*z + w*w));
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public long Sum => ((x + y) + (z + w));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => ((Math.Abs(x) + Math.Abs(y)) + (Math.Abs(z) + Math.Abs(w)));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Max(Math.Abs(z), Math.Abs(w)));

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static lvec4 Zero { get; } = new lvec4(0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static lvec4 Ones { get; } = new lvec4(1, 1, 1, 1);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static lvec4 UnitX { get; } = new lvec4(1, 0, 0, 0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static lvec4 UnitY { get; } = new lvec4(0, 1, 0, 0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static lvec4 UnitZ { get; } = new lvec4(0, 0, 1, 0);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static lvec4 UnitW { get; } = new lvec4(0, 0, 0, 1);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static lvec4 MaxValue { get; } = new lvec4(long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static lvec4 MinValue { get; } = new lvec4(long.MinValue, long.MinValue, long.MinValue, long.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(lvec4 lhs, lvec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(lvec4 lhs, lvec4 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<long> GetEnumerator()
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
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => ((x + sep + y) + sep + (z + sep + w));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => ((x.ToString(provider) + sep + y.ToString(provider)) + sep + (z.ToString(provider) + sep + w.ToString(provider)));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => ((x.ToString(format) + sep + y.ToString(format)) + sep + (z.ToString(format) + sep + w.ToString(format)));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => ((x.ToString(format, provider) + sep + y.ToString(format, provider)) + sep + (z.ToString(format, provider) + sep + w.ToString(format, provider)));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(lvec4 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is lvec4 && Equals((lvec4) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((x.GetHashCode()) * 397) ^ y.GetHashCode()) * 397) ^ z.GetHashCode()) * 397) ^ w.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(((Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p)) + (Math.Pow((double)Math.Abs(z), p) + Math.Pow((double)Math.Abs(w), p))), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static lvec4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static lvec4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new lvec4(long.Parse(kvp[0].Trim()), long.Parse(kvp[1].Trim()), long.Parse(kvp[2].Trim()), long.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static lvec4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new lvec4(long.Parse(kvp[0].Trim(), provider), long.Parse(kvp[1].Trim(), provider), long.Parse(kvp[2].Trim(), provider), long.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static lvec4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new lvec4(long.Parse(kvp[0].Trim(), style), long.Parse(kvp[1].Trim(), style), long.Parse(kvp[2].Trim(), style), long.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static lvec4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new lvec4(long.Parse(kvp[0].Trim(), style, provider), long.Parse(kvp[1].Trim(), style, provider), long.Parse(kvp[2].Trim(), style, provider), long.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out lvec4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out lvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            long x = 0, y = 0, z = 0, w = 0;
            var ok = ((long.TryParse(kvp[0].Trim(), out x) && long.TryParse(kvp[1].Trim(), out y)) && (long.TryParse(kvp[2].Trim(), out z) && long.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new lvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out lvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            long x = 0, y = 0, z = 0, w = 0;
            var ok = ((long.TryParse(kvp[0].Trim(), style, provider, out x) && long.TryParse(kvp[1].Trim(), style, provider, out y)) && (long.TryParse(kvp[2].Trim(), style, provider, out z) && long.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new lvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat4x2 OuterProduct(lvec2 c, lvec4 r) => new lmat4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat2x4 OuterProduct(lvec4 c, lvec2 r) => new lmat2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat4x3 OuterProduct(lvec3 c, lvec4 r) => new lmat4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat3x4 OuterProduct(lvec4 c, lvec3 r) => new lmat3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat4 OuterProduct(lvec4 c, lvec4 r) => new lmat4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static long Dot(lvec4 lhs, lvec4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(lvec4 lhs, lvec4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(lvec4 lhs, lvec4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec4 Reflect(lvec4 I, lvec4 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec4 Refract(lvec4 I, lvec4 N, long eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (long)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static lvec4 FaceForward(lvec4 N, lvec4 I, lvec4 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive).
        /// </summary>
        public static lvec4 Random(Random random) => new lvec4((long)random.Next(), (long)random.Next(), (long)random.Next(), (long)random.Next());

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(lvec4 lhs, long rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(long lhs, lvec4 rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(long lhs, long rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(lvec4 lhs, long rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(long lhs, lvec4 rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(long lhs, long rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(lvec4 lhs, long rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(long lhs, lvec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(long lhs, long rhs) => new bvec4(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(lvec4 lhs, long rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(long lhs, lvec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(long lhs, long rhs) => new bvec4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(lvec4 lhs, long rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(long lhs, lvec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(long lhs, long rhs) => new bvec4(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(lvec4 lhs, long rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(long lhs, lvec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(long lhs, long rhs) => new bvec4(lhs <= rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static lvec4 Abs(lvec4 v) => new lvec4(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w));
        
        /// <summary>
        /// Returns a lvec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static lvec4 Abs(long v) => new lvec4(Math.Abs(v));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static lvec4 HermiteInterpolationOrder3(lvec4 v) => new lvec4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a lvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static lvec4 HermiteInterpolationOrder3(long v) => new lvec4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static lvec4 HermiteInterpolationOrder5(lvec4 v) => new lvec4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a lvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static lvec4 HermiteInterpolationOrder5(long v) => new lvec4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static lvec4 Sqr(lvec4 v) => new lvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a lvec from the application of Sqr (v * v).
        /// </summary>
        public static lvec4 Sqr(long v) => new lvec4(v * v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static lvec4 Pow2(lvec4 v) => new lvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a lvec from the application of Pow2 (v * v).
        /// </summary>
        public static lvec4 Pow2(long v) => new lvec4(v * v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static lvec4 Pow3(lvec4 v) => new lvec4(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a lvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static lvec4 Pow3(long v) => new lvec4(v * v * v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static lvec4 Step(lvec4 v) => new lvec4(v.x >= 0 ? 1 : 0, v.y >= 0 ? 1 : 0, v.z >= 0 ? 1 : 0, v.w >= 0 ? 1 : 0);
        
        /// <summary>
        /// Returns a lvec from the application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static lvec4 Step(long v) => new lvec4(v >= 0 ? 1 : 0);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Sqrt ((long)Math.Sqrt((double)v)).
        /// </summary>
        public static lvec4 Sqrt(lvec4 v) => new lvec4((long)Math.Sqrt((double)v.x), (long)Math.Sqrt((double)v.y), (long)Math.Sqrt((double)v.z), (long)Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a lvec from the application of Sqrt ((long)Math.Sqrt((double)v)).
        /// </summary>
        public static lvec4 Sqrt(long v) => new lvec4((long)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of InverseSqrt ((long)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static lvec4 InverseSqrt(lvec4 v) => new lvec4((long)(1.0 / Math.Sqrt((double)v.x)), (long)(1.0 / Math.Sqrt((double)v.y)), (long)(1.0 / Math.Sqrt((double)v.z)), (long)(1.0 / Math.Sqrt((double)v.w)));
        
        /// <summary>
        /// Returns a lvec from the application of InverseSqrt ((long)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static lvec4 InverseSqrt(long v) => new lvec4((long)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(lvec4 v) => new ivec4(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(long v) => new ivec4(Math.Sign(v));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static lvec4 Max(lvec4 lhs, lvec4 rhs) => new lvec4(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static lvec4 Max(lvec4 lhs, long rhs) => new lvec4(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs), Math.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static lvec4 Max(long lhs, lvec4 rhs) => new lvec4(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z), Math.Max(lhs, rhs.w));
        
        /// <summary>
        /// Returns a lvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static lvec4 Max(long lhs, long rhs) => new lvec4(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static lvec4 Min(lvec4 lhs, lvec4 rhs) => new lvec4(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static lvec4 Min(lvec4 lhs, long rhs) => new lvec4(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs), Math.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static lvec4 Min(long lhs, lvec4 rhs) => new lvec4(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z), Math.Min(lhs, rhs.w));
        
        /// <summary>
        /// Returns a lvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static lvec4 Min(long lhs, long rhs) => new lvec4(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Pow(lvec4 lhs, lvec4 rhs) => new lvec4((long)Math.Pow((double)lhs.x, (double)rhs.x), (long)Math.Pow((double)lhs.y, (double)rhs.y), (long)Math.Pow((double)lhs.z, (double)rhs.z), (long)Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Pow(lvec4 lhs, long rhs) => new lvec4((long)Math.Pow((double)lhs.x, (double)rhs), (long)Math.Pow((double)lhs.y, (double)rhs), (long)Math.Pow((double)lhs.z, (double)rhs), (long)Math.Pow((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Pow(long lhs, lvec4 rhs) => new lvec4((long)Math.Pow((double)lhs, (double)rhs.x), (long)Math.Pow((double)lhs, (double)rhs.y), (long)Math.Pow((double)lhs, (double)rhs.z), (long)Math.Pow((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a lvec from the application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Pow(long lhs, long rhs) => new lvec4((long)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Log(lvec4 lhs, lvec4 rhs) => new lvec4((long)Math.Log((double)lhs.x, (double)rhs.x), (long)Math.Log((double)lhs.y, (double)rhs.y), (long)Math.Log((double)lhs.z, (double)rhs.z), (long)Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Log(lvec4 lhs, long rhs) => new lvec4((long)Math.Log((double)lhs.x, (double)rhs), (long)Math.Log((double)lhs.y, (double)rhs), (long)Math.Log((double)lhs.z, (double)rhs), (long)Math.Log((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Log(long lhs, lvec4 rhs) => new lvec4((long)Math.Log((double)lhs, (double)rhs.x), (long)Math.Log((double)lhs, (double)rhs.y), (long)Math.Log((double)lhs, (double)rhs.z), (long)Math.Log((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a lvec from the application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Log(long lhs, long rhs) => new lvec4((long)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(lvec4 v, lvec4 min, lvec4 max) => new lvec4(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(lvec4 v, lvec4 min, long max) => new lvec4(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(lvec4 v, long min, lvec4 max) => new lvec4(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(lvec4 v, long min, long max) => new lvec4(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(long v, lvec4 min, lvec4 max) => new lvec4(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(long v, lvec4 min, long max) => new lvec4(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(long v, long min, lvec4 max) => new lvec4(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a lvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(long v, long min, long max) => new lvec4(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(lvec4 min, lvec4 max, lvec4 a) => new lvec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(lvec4 min, lvec4 max, long a) => new lvec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(lvec4 min, long max, lvec4 a) => new lvec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(lvec4 min, long max, long a) => new lvec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(long min, lvec4 max, lvec4 a) => new lvec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(long min, lvec4 max, long a) => new lvec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(long min, long max, lvec4 a) => new lvec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a lvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(long min, long max, long a) => new lvec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(lvec4 min, lvec4 max, lvec4 a) => new lvec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(lvec4 min, lvec4 max, long a) => new lvec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(lvec4 min, long max, lvec4 a) => new lvec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(lvec4 min, long max, long a) => new lvec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(long min, lvec4 max, lvec4 a) => new lvec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(long min, lvec4 max, long a) => new lvec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(long min, long max, lvec4 a) => new lvec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a lvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(long min, long max, long a) => new lvec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(lvec4 edge0, lvec4 edge1, lvec4 v) => new lvec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(lvec4 edge0, lvec4 edge1, long v) => new lvec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(lvec4 edge0, long edge1, lvec4 v) => new lvec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(lvec4 edge0, long edge1, long v) => new lvec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(long edge0, lvec4 edge1, lvec4 v) => new lvec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(long edge0, lvec4 edge1, long v) => new lvec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(long edge0, long edge1, lvec4 v) => new lvec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a lvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(long edge0, long edge1, long v) => new lvec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(lvec4 edge0, lvec4 edge1, lvec4 v) => new lvec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(lvec4 edge0, lvec4 edge1, long v) => new lvec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(lvec4 edge0, long edge1, lvec4 v) => new lvec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(lvec4 edge0, long edge1, long v) => new lvec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(long edge0, lvec4 edge1, lvec4 v) => new lvec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(long edge0, lvec4 edge1, long v) => new lvec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(long edge0, long edge1, lvec4 v) => new lvec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a lvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(long edge0, long edge1, long v) => new lvec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(lvec4 a, lvec4 b, lvec4 c) => new lvec4(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(lvec4 a, lvec4 b, long c) => new lvec4(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(lvec4 a, long b, lvec4 c) => new lvec4(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(lvec4 a, long b, long c) => new lvec4(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(long a, lvec4 b, lvec4 c) => new lvec4(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(long a, lvec4 b, long c) => new lvec4(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(long a, long b, lvec4 c) => new lvec4(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w);
        
        /// <summary>
        /// Returns a lvec from the application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(long a, long b, long c) => new lvec4(a * b + c);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static lvec4 Add(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static lvec4 Add(lvec4 lhs, long rhs) => new lvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static lvec4 Add(long lhs, lvec4 rhs) => new lvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of Add (lhs + rhs).
        /// </summary>
        public static lvec4 Add(long lhs, long rhs) => new lvec4(lhs + rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static lvec4 Sub(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static lvec4 Sub(lvec4 lhs, long rhs) => new lvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static lvec4 Sub(long lhs, lvec4 rhs) => new lvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static lvec4 Sub(long lhs, long rhs) => new lvec4(lhs - rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static lvec4 Mul(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static lvec4 Mul(lvec4 lhs, long rhs) => new lvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static lvec4 Mul(long lhs, lvec4 rhs) => new lvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static lvec4 Mul(long lhs, long rhs) => new lvec4(lhs * rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static lvec4 Div(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static lvec4 Div(lvec4 lhs, long rhs) => new lvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static lvec4 Div(long lhs, lvec4 rhs) => new lvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of Div (lhs / rhs).
        /// </summary>
        public static lvec4 Div(long lhs, long rhs) => new lvec4(lhs / rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static lvec4 Xor(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static lvec4 Xor(lvec4 lhs, long rhs) => new lvec4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static lvec4 Xor(long lhs, lvec4 rhs) => new lvec4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of Xor (lhs ^ rhs).
        /// </summary>
        public static lvec4 Xor(long lhs, long rhs) => new lvec4(lhs ^ rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static lvec4 BitwiseOr(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static lvec4 BitwiseOr(lvec4 lhs, long rhs) => new lvec4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static lvec4 BitwiseOr(long lhs, lvec4 rhs) => new lvec4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static lvec4 BitwiseOr(long lhs, long rhs) => new lvec4(lhs | rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static lvec4 BitwiseAnd(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static lvec4 BitwiseAnd(lvec4 lhs, long rhs) => new lvec4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static lvec4 BitwiseAnd(long lhs, lvec4 rhs) => new lvec4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static lvec4 BitwiseAnd(long lhs, long rhs) => new lvec4(lhs & rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec4 LeftShift(lvec4 lhs, ivec4 rhs) => new lvec4(lhs.x << rhs.x, lhs.y << rhs.y, lhs.z << rhs.z, lhs.w << rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec4 LeftShift(lvec4 lhs, int rhs) => new lvec4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec4 LeftShift(long lhs, ivec4 rhs) => new lvec4(lhs << rhs.x, lhs << rhs.y, lhs << rhs.z, lhs << rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec4 LeftShift(long lhs, int rhs) => new lvec4(lhs << rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec4 RightShift(lvec4 lhs, ivec4 rhs) => new lvec4(lhs.x >> rhs.x, lhs.y >> rhs.y, lhs.z >> rhs.z, lhs.w >> rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec4 RightShift(lvec4 lhs, int rhs) => new lvec4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec4 RightShift(long lhs, ivec4 rhs) => new lvec4(lhs >> rhs.x, lhs >> rhs.y, lhs >> rhs.z, lhs >> rhs.w);
        
        /// <summary>
        /// Returns a lvec from the application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec4 RightShift(long lhs, int rhs) => new lvec4(lhs >> rhs);
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static lvec4 Random(Random random, lvec4 maxValue) => new lvec4((long)random.Next((int)maxValue.x), (long)random.Next((int)maxValue.y), (long)random.Next((int)maxValue.z), (long)random.Next((int)maxValue.w));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static lvec4 Random(Random random, long maxValue) => new lvec4((long)random.Next((int)maxValue));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 Random(Random random, lvec4 minValue, lvec4 maxValue) => new lvec4((long)random.Next((int)minValue.x, (int)maxValue.x), (long)random.Next((int)minValue.y, (int)maxValue.y), (long)random.Next((int)minValue.z, (int)maxValue.z), (long)random.Next((int)minValue.w, (int)maxValue.w));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 Random(Random random, lvec4 minValue, long maxValue) => new lvec4((long)random.Next((int)minValue.x, (int)maxValue), (long)random.Next((int)minValue.y, (int)maxValue), (long)random.Next((int)minValue.z, (int)maxValue), (long)random.Next((int)minValue.w, (int)maxValue));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 Random(Random random, long minValue, lvec4 maxValue) => new lvec4((long)random.Next((int)minValue, (int)maxValue.x), (long)random.Next((int)minValue, (int)maxValue.y), (long)random.Next((int)minValue, (int)maxValue.z), (long)random.Next((int)minValue, (int)maxValue.w));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 Random(Random random, long minValue, long maxValue) => new lvec4((long)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 RandomUniform(Random random, lvec4 minValue, lvec4 maxValue) => new lvec4((long)random.Next((int)minValue.x, (int)maxValue.x), (long)random.Next((int)minValue.y, (int)maxValue.y), (long)random.Next((int)minValue.z, (int)maxValue.z), (long)random.Next((int)minValue.w, (int)maxValue.w));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 RandomUniform(Random random, lvec4 minValue, long maxValue) => new lvec4((long)random.Next((int)minValue.x, (int)maxValue), (long)random.Next((int)minValue.y, (int)maxValue), (long)random.Next((int)minValue.z, (int)maxValue), (long)random.Next((int)minValue.w, (int)maxValue));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 RandomUniform(Random random, long minValue, lvec4 maxValue) => new lvec4((long)random.Next((int)minValue, (int)maxValue.x), (long)random.Next((int)minValue, (int)maxValue.y), (long)random.Next((int)minValue, (int)maxValue.z), (long)random.Next((int)minValue, (int)maxValue.w));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 RandomUniform(Random random, long minValue, long maxValue) => new lvec4((long)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static lvec4 RandomPoisson(Random random, dvec4 lambda) => new lvec4((long)lambda.x.GetPoisson(random), (long)lambda.y.GetPoisson(random), (long)lambda.z.GetPoisson(random), (long)lambda.w.GetPoisson(random));
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static lvec4 RandomPoisson(Random random, double lambda) => new lvec4((long)lambda.GetPoisson(random));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(lvec4 lhs, long rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(long lhs, lvec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(lvec4 lhs, long rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(long lhs, lvec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(lvec4 lhs, long rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(long lhs, lvec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(lvec4 lhs, lvec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(lvec4 lhs, long rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(long lhs, lvec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static lvec4 operator+(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static lvec4 operator+(lvec4 lhs, long rhs) => new lvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static lvec4 operator+(long lhs, lvec4 rhs) => new lvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static lvec4 operator-(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static lvec4 operator-(lvec4 lhs, long rhs) => new lvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static lvec4 operator-(long lhs, lvec4 rhs) => new lvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static lvec4 operator*(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static lvec4 operator*(lvec4 lhs, long rhs) => new lvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static lvec4 operator*(long lhs, lvec4 rhs) => new lvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static lvec4 operator/(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static lvec4 operator/(lvec4 lhs, long rhs) => new lvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static lvec4 operator/(long lhs, lvec4 rhs) => new lvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator+ (identity).
        /// </summary>
        public static lvec4 operator+(lvec4 v) => v;
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator- (-v).
        /// </summary>
        public static lvec4 operator-(lvec4 v) => new lvec4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator~ (~v).
        /// </summary>
        public static lvec4 operator~(lvec4 v) => new lvec4(~v.x, ~v.y, ~v.z, ~v.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static lvec4 operator^(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static lvec4 operator^(lvec4 lhs, long rhs) => new lvec4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static lvec4 operator^(long lhs, lvec4 rhs) => new lvec4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static lvec4 operator|(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static lvec4 operator|(lvec4 lhs, long rhs) => new lvec4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static lvec4 operator|(long lhs, lvec4 rhs) => new lvec4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static lvec4 operator&(lvec4 lhs, lvec4 rhs) => new lvec4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static lvec4 operator&(lvec4 lhs, long rhs) => new lvec4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static lvec4 operator&(long lhs, lvec4 rhs) => new lvec4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec4 operator<<(lvec4 lhs, int rhs) => new lvec4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec4 operator>>(lvec4 lhs, int rhs) => new lvec4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);

        #endregion

    }
}
