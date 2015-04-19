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
    /// A vector of type uint with 4 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct uvec4 : IReadOnlyList<uint>, IEquatable<uvec4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public uint y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public uint z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public uint w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public uvec4(uint x, uint y, uint z, uint w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public uvec4(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uvec4(uvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0u;
            this.w = 0u;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public uvec4(uvec2 v, uint z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0u;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public uvec4(uvec2 v, uint z, uint w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uvec4(uvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0u;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public uvec4(uvec3 v, uint w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public uvec4(uvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec4(IReadOnlyList<uint> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0u : v[0];
            this.y = c < 1 ? 0u : v[1];
            this.z = c < 2 ? 0u : v[2];
            this.w = c < 3 ? 0u : v[3];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec4(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0u : (uint)v[0];
            this.y = c < 1 ? 0u : (uint)v[1];
            this.z = c < 2 ? 0u : (uint)v[2];
            this.w = c < 3 ? 0u : (uint)v[3];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec4(uint[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0u : v[0];
            this.y = c < 1 ? 0u : v[1];
            this.z = c < 2 ? 0u : v[2];
            this.w = c < 3 ? 0u : v[3];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec4(uint[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0u : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0u : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0u : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0u : v[3 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec4(IEnumerable<uint> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a lvec4.
        /// </summary>
        public static implicit operator lvec4(uvec4 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Implicitly converts this to a vec4.
        /// </summary>
        public static implicit operator vec4(uvec4 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Implicitly converts this to a hvec4.
        /// </summary>
        public static implicit operator hvec4(uvec4 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Implicitly converts this to a dvec4.
        /// </summary>
        public static implicit operator dvec4(uvec4 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Implicitly converts this to a decvec4.
        /// </summary>
        public static implicit operator decvec4(uvec4 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Implicitly converts this to a cvec4.
        /// </summary>
        public static implicit operator cvec4(uvec4 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(uvec4 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(uvec4 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(uvec4 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(uvec4 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(uvec4 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(uvec4 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(uvec4 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(uvec4 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(uvec4 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(uvec4 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(uvec4 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(uvec4 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(uvec4 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(uvec4 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(uvec4 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(uvec4 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(uvec4 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(uvec4 v) => new bvec2(v.x != 0u, v.y != 0u);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(uvec4 v) => new bvec3(v.x != 0u, v.y != 0u, v.z != 0u);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(uvec4 v) => new bvec4(v.x != 0u, v.y != 0u, v.z != 0u, v.w != 0u);
        
        /// <summary>
        /// Explicitly converts this to a uint array.
        /// </summary>
        public static explicit operator uint[](uvec4 v) => new [] { v.x, v.y, v.z, v.w };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](uvec4 v) => new Object[] { v.x, v.y, v.z, v.w };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public uint this[int index]
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
        public swizzle_uvec4 swizzle => new swizzle_uvec4(x, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uvec2 xy
        {
            get
            {
                return new uvec2(x, y);
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
        public uvec2 xz
        {
            get
            {
                return new uvec2(x, z);
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
        public uvec2 yz
        {
            get
            {
                return new uvec2(y, z);
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
        public uvec3 xyz
        {
            get
            {
                return new uvec3(x, y, z);
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
        public uvec2 xw
        {
            get
            {
                return new uvec2(x, w);
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
        public uvec2 yw
        {
            get
            {
                return new uvec2(y, w);
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
        public uvec3 xyw
        {
            get
            {
                return new uvec3(x, y, w);
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
        public uvec2 zw
        {
            get
            {
                return new uvec2(z, w);
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
        public uvec3 xzw
        {
            get
            {
                return new uvec3(x, z, w);
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
        public uvec3 yzw
        {
            get
            {
                return new uvec3(y, z, w);
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
        public uvec4 xyzw
        {
            get
            {
                return new uvec4(x, y, z, w);
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
        public uvec2 rg
        {
            get
            {
                return new uvec2(x, y);
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
        public uvec2 rb
        {
            get
            {
                return new uvec2(x, z);
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
        public uvec2 gb
        {
            get
            {
                return new uvec2(y, z);
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
        public uvec3 rgb
        {
            get
            {
                return new uvec3(x, y, z);
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
        public uvec2 ra
        {
            get
            {
                return new uvec2(x, w);
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
        public uvec2 ga
        {
            get
            {
                return new uvec2(y, w);
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
        public uvec3 rga
        {
            get
            {
                return new uvec3(x, y, w);
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
        public uvec2 ba
        {
            get
            {
                return new uvec2(z, w);
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
        public uvec3 rba
        {
            get
            {
                return new uvec3(x, z, w);
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
        public uvec3 gba
        {
            get
            {
                return new uvec3(y, z, w);
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
        public uvec4 rgba
        {
            get
            {
                return new uvec4(x, y, z, w);
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
        public uint r
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
        public uint g
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
        public uint b
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
        public uint a
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
        public uint[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public uint MinElement => Math.Min(Math.Min(x, y), Math.Min(z, w));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public uint MaxElement => Math.Max(Math.Max(x, y), Math.Max(z, w));
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => ((x*x + y*y) + (z*z + w*w));
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public uint Sum => ((x + y) + (z + w));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => ((x + y) + (z + w));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => Math.Max(Math.Max(x, y), Math.Max(z, w));

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static uvec4 Zero { get; } = new uvec4(0u, 0u, 0u, 0u);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static uvec4 Ones { get; } = new uvec4(1u, 1u, 1u, 1u);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static uvec4 UnitX { get; } = new uvec4(1u, 0u, 0u, 0u);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static uvec4 UnitY { get; } = new uvec4(0u, 1u, 0u, 0u);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static uvec4 UnitZ { get; } = new uvec4(0u, 0u, 1u, 0u);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static uvec4 UnitW { get; } = new uvec4(0u, 0u, 0u, 1u);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static uvec4 MaxValue { get; } = new uvec4(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static uvec4 MinValue { get; } = new uvec4(uint.MinValue, uint.MinValue, uint.MinValue, uint.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(uvec4 lhs, uvec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(uvec4 lhs, uvec4 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<uint> GetEnumerator()
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
        public bool Equals(uvec4 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is uvec4 && Equals((uvec4) obj);
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
        public double NormP(double p) => Math.Pow(((Math.Pow((double)x, p) + Math.Pow((double)y, p)) + (Math.Pow((double)z, p) + Math.Pow((double)w, p))), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static uvec4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static uvec4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new uvec4(uint.Parse(kvp[0].Trim()), uint.Parse(kvp[1].Trim()), uint.Parse(kvp[2].Trim()), uint.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static uvec4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new uvec4(uint.Parse(kvp[0].Trim(), provider), uint.Parse(kvp[1].Trim(), provider), uint.Parse(kvp[2].Trim(), provider), uint.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static uvec4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new uvec4(uint.Parse(kvp[0].Trim(), style), uint.Parse(kvp[1].Trim(), style), uint.Parse(kvp[2].Trim(), style), uint.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static uvec4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new uvec4(uint.Parse(kvp[0].Trim(), style, provider), uint.Parse(kvp[1].Trim(), style, provider), uint.Parse(kvp[2].Trim(), style, provider), uint.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out uvec4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out uvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            uint x = 0u, y = 0u, z = 0u, w = 0u;
            var ok = ((uint.TryParse(kvp[0].Trim(), out x) && uint.TryParse(kvp[1].Trim(), out y)) && (uint.TryParse(kvp[2].Trim(), out z) && uint.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new uvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out uvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            uint x = 0u, y = 0u, z = 0u, w = 0u;
            var ok = ((uint.TryParse(kvp[0].Trim(), style, provider, out x) && uint.TryParse(kvp[1].Trim(), style, provider, out y)) && (uint.TryParse(kvp[2].Trim(), style, provider, out z) && uint.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new uvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat4x2 OuterProduct(uvec2 c, uvec4 r) => new umat4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat2x4 OuterProduct(uvec4 c, uvec2 r) => new umat2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat4x3 OuterProduct(uvec3 c, uvec4 r) => new umat4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat3x4 OuterProduct(uvec4 c, uvec3 r) => new umat3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat4 OuterProduct(uvec4 c, uvec4 r) => new umat4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uvec4 lhs, uvec4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(uvec4 lhs, uvec4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(uvec4 lhs, uvec4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive).
        /// </summary>
        public static uvec4 Random(Random random) => new uvec4((uint)random.Next(), (uint)random.Next(), (uint)random.Next(), (uint)random.Next());

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(uvec4 lhs, uint rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(uint lhs, uvec4 rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(uint lhs, uint rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(uvec4 lhs, uint rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(uint lhs, uvec4 rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(uint lhs, uint rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(uvec4 lhs, uint rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(uint lhs, uvec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(uint lhs, uint rhs) => new bvec4(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(uvec4 lhs, uint rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(uint lhs, uvec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(uint lhs, uint rhs) => new bvec4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(uvec4 lhs, uint rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(uint lhs, uvec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(uint lhs, uint rhs) => new bvec4(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(uvec4 lhs, uint rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(uint lhs, uvec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(uint lhs, uint rhs) => new bvec4(lhs <= rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Abs (v).
        /// </summary>
        public static uvec4 Abs(uvec4 v) => new uvec4(v.x, v.y, v.z, v.w);
        
        /// <summary>
        /// Returns a uvec from the application of Abs (v).
        /// </summary>
        public static uvec4 Abs(uint v) => new uvec4(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uvec4 HermiteInterpolationOrder3(uvec4 v) => new uvec4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a uvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uvec4 HermiteInterpolationOrder3(uint v) => new uvec4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uvec4 HermiteInterpolationOrder5(uvec4 v) => new uvec4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a uvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uvec4 HermiteInterpolationOrder5(uint v) => new uvec4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uvec4 Sqr(uvec4 v) => new uvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a uvec from the application of Sqr (v * v).
        /// </summary>
        public static uvec4 Sqr(uint v) => new uvec4(v * v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uvec4 Pow2(uvec4 v) => new uvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a uvec from the application of Pow2 (v * v).
        /// </summary>
        public static uvec4 Pow2(uint v) => new uvec4(v * v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uvec4 Pow3(uvec4 v) => new uvec4(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a uvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static uvec4 Pow3(uint v) => new uvec4(v * v * v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uvec4 Step(uvec4 v) => new uvec4(v.x >= 0u ? 1u : 0u, v.y >= 0u ? 1u : 0u, v.z >= 0u ? 1u : 0u, v.w >= 0u ? 1u : 0u);
        
        /// <summary>
        /// Returns a uvec from the application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uvec4 Step(uint v) => new uvec4(v >= 0u ? 1u : 0u);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uvec4 Sqrt(uvec4 v) => new uvec4((uint)Math.Sqrt((double)v.x), (uint)Math.Sqrt((double)v.y), (uint)Math.Sqrt((double)v.z), (uint)Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a uvec from the application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uvec4 Sqrt(uint v) => new uvec4((uint)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uvec4 InverseSqrt(uvec4 v) => new uvec4((uint)(1.0 / Math.Sqrt((double)v.x)), (uint)(1.0 / Math.Sqrt((double)v.y)), (uint)(1.0 / Math.Sqrt((double)v.z)), (uint)(1.0 / Math.Sqrt((double)v.w)));
        
        /// <summary>
        /// Returns a uvec from the application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uvec4 InverseSqrt(uint v) => new uvec4((uint)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(uvec4 v) => new ivec4(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(uint v) => new ivec4(Math.Sign(v));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec4 Max(uvec4 lhs, uvec4 rhs) => new uvec4(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec4 Max(uvec4 lhs, uint rhs) => new uvec4(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs), Math.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec4 Max(uint lhs, uvec4 rhs) => new uvec4(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z), Math.Max(lhs, rhs.w));
        
        /// <summary>
        /// Returns a uvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec4 Max(uint lhs, uint rhs) => new uvec4(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec4 Min(uvec4 lhs, uvec4 rhs) => new uvec4(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec4 Min(uvec4 lhs, uint rhs) => new uvec4(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs), Math.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec4 Min(uint lhs, uvec4 rhs) => new uvec4(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z), Math.Min(lhs, rhs.w));
        
        /// <summary>
        /// Returns a uvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec4 Min(uint lhs, uint rhs) => new uvec4(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Pow(uvec4 lhs, uvec4 rhs) => new uvec4((uint)Math.Pow((double)lhs.x, (double)rhs.x), (uint)Math.Pow((double)lhs.y, (double)rhs.y), (uint)Math.Pow((double)lhs.z, (double)rhs.z), (uint)Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Pow(uvec4 lhs, uint rhs) => new uvec4((uint)Math.Pow((double)lhs.x, (double)rhs), (uint)Math.Pow((double)lhs.y, (double)rhs), (uint)Math.Pow((double)lhs.z, (double)rhs), (uint)Math.Pow((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Pow(uint lhs, uvec4 rhs) => new uvec4((uint)Math.Pow((double)lhs, (double)rhs.x), (uint)Math.Pow((double)lhs, (double)rhs.y), (uint)Math.Pow((double)lhs, (double)rhs.z), (uint)Math.Pow((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a uvec from the application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Pow(uint lhs, uint rhs) => new uvec4((uint)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Log(uvec4 lhs, uvec4 rhs) => new uvec4((uint)Math.Log((double)lhs.x, (double)rhs.x), (uint)Math.Log((double)lhs.y, (double)rhs.y), (uint)Math.Log((double)lhs.z, (double)rhs.z), (uint)Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Log(uvec4 lhs, uint rhs) => new uvec4((uint)Math.Log((double)lhs.x, (double)rhs), (uint)Math.Log((double)lhs.y, (double)rhs), (uint)Math.Log((double)lhs.z, (double)rhs), (uint)Math.Log((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Log(uint lhs, uvec4 rhs) => new uvec4((uint)Math.Log((double)lhs, (double)rhs.x), (uint)Math.Log((double)lhs, (double)rhs.y), (uint)Math.Log((double)lhs, (double)rhs.z), (uint)Math.Log((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a uvec from the application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Log(uint lhs, uint rhs) => new uvec4((uint)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uvec4 v, uvec4 min, uvec4 max) => new uvec4(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uvec4 v, uvec4 min, uint max) => new uvec4(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uvec4 v, uint min, uvec4 max) => new uvec4(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uvec4 v, uint min, uint max) => new uvec4(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uint v, uvec4 min, uvec4 max) => new uvec4(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uint v, uvec4 min, uint max) => new uvec4(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uint v, uint min, uvec4 max) => new uvec4(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a uvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uint v, uint min, uint max) => new uvec4(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uvec4 min, uvec4 max, uvec4 a) => new uvec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uvec4 min, uvec4 max, uint a) => new uvec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uvec4 min, uint max, uvec4 a) => new uvec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uvec4 min, uint max, uint a) => new uvec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uint min, uvec4 max, uvec4 a) => new uvec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uint min, uvec4 max, uint a) => new uvec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uint min, uint max, uvec4 a) => new uvec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a uvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uint min, uint max, uint a) => new uvec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uvec4 min, uvec4 max, uvec4 a) => new uvec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uvec4 min, uvec4 max, uint a) => new uvec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uvec4 min, uint max, uvec4 a) => new uvec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uvec4 min, uint max, uint a) => new uvec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uint min, uvec4 max, uvec4 a) => new uvec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uint min, uvec4 max, uint a) => new uvec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uint min, uint max, uvec4 a) => new uvec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a uvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uint min, uint max, uint a) => new uvec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uvec4 edge0, uvec4 edge1, uvec4 v) => new uvec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uvec4 edge0, uvec4 edge1, uint v) => new uvec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uvec4 edge0, uint edge1, uvec4 v) => new uvec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uvec4 edge0, uint edge1, uint v) => new uvec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uint edge0, uvec4 edge1, uvec4 v) => new uvec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uint edge0, uvec4 edge1, uint v) => new uvec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uint edge0, uint edge1, uvec4 v) => new uvec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uint edge0, uint edge1, uint v) => new uvec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uvec4 edge0, uvec4 edge1, uvec4 v) => new uvec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uvec4 edge0, uvec4 edge1, uint v) => new uvec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uvec4 edge0, uint edge1, uvec4 v) => new uvec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uvec4 edge0, uint edge1, uint v) => new uvec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uint edge0, uvec4 edge1, uvec4 v) => new uvec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uint edge0, uvec4 edge1, uint v) => new uvec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uint edge0, uint edge1, uvec4 v) => new uvec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uint edge0, uint edge1, uint v) => new uvec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uvec4 a, uvec4 b, uvec4 c) => new uvec4(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uvec4 a, uvec4 b, uint c) => new uvec4(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uvec4 a, uint b, uvec4 c) => new uvec4(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uvec4 a, uint b, uint c) => new uvec4(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uint a, uvec4 b, uvec4 c) => new uvec4(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uint a, uvec4 b, uint c) => new uvec4(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uint a, uint b, uvec4 c) => new uvec4(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w);
        
        /// <summary>
        /// Returns a uvec from the application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uint a, uint b, uint c) => new uvec4(a * b + c);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec4 Add(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec4 Add(uvec4 lhs, uint rhs) => new uvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec4 Add(uint lhs, uvec4 rhs) => new uvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of Add (lhs + rhs).
        /// </summary>
        public static uvec4 Add(uint lhs, uint rhs) => new uvec4(lhs + rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec4 Sub(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec4 Sub(uvec4 lhs, uint rhs) => new uvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec4 Sub(uint lhs, uvec4 rhs) => new uvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static uvec4 Sub(uint lhs, uint rhs) => new uvec4(lhs - rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec4 Mul(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec4 Mul(uvec4 lhs, uint rhs) => new uvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec4 Mul(uint lhs, uvec4 rhs) => new uvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static uvec4 Mul(uint lhs, uint rhs) => new uvec4(lhs * rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec4 Div(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec4 Div(uvec4 lhs, uint rhs) => new uvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec4 Div(uint lhs, uvec4 rhs) => new uvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of Div (lhs / rhs).
        /// </summary>
        public static uvec4 Div(uint lhs, uint rhs) => new uvec4(lhs / rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec4 Xor(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec4 Xor(uvec4 lhs, uint rhs) => new uvec4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec4 Xor(uint lhs, uvec4 rhs) => new uvec4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec4 Xor(uint lhs, uint rhs) => new uvec4(lhs ^ rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec4 BitwiseOr(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec4 BitwiseOr(uvec4 lhs, uint rhs) => new uvec4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec4 BitwiseOr(uint lhs, uvec4 rhs) => new uvec4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec4 BitwiseOr(uint lhs, uint rhs) => new uvec4(lhs | rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec4 BitwiseAnd(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec4 BitwiseAnd(uvec4 lhs, uint rhs) => new uvec4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec4 BitwiseAnd(uint lhs, uvec4 rhs) => new uvec4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec4 BitwiseAnd(uint lhs, uint rhs) => new uvec4(lhs & rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec4 LeftShift(uvec4 lhs, ivec4 rhs) => new uvec4(lhs.x << rhs.x, lhs.y << rhs.y, lhs.z << rhs.z, lhs.w << rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec4 LeftShift(uvec4 lhs, int rhs) => new uvec4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec4 LeftShift(uint lhs, ivec4 rhs) => new uvec4(lhs << rhs.x, lhs << rhs.y, lhs << rhs.z, lhs << rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec4 LeftShift(uint lhs, int rhs) => new uvec4(lhs << rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec4 RightShift(uvec4 lhs, ivec4 rhs) => new uvec4(lhs.x >> rhs.x, lhs.y >> rhs.y, lhs.z >> rhs.z, lhs.w >> rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec4 RightShift(uvec4 lhs, int rhs) => new uvec4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec4 RightShift(uint lhs, ivec4 rhs) => new uvec4(lhs >> rhs.x, lhs >> rhs.y, lhs >> rhs.z, lhs >> rhs.w);
        
        /// <summary>
        /// Returns a uvec from the application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec4 RightShift(uint lhs, int rhs) => new uvec4(lhs >> rhs);
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uvec4 Random(Random random, uvec4 maxValue) => new uvec4((uint)random.Next((int)maxValue.x), (uint)random.Next((int)maxValue.y), (uint)random.Next((int)maxValue.z), (uint)random.Next((int)maxValue.w));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uvec4 Random(Random random, uint maxValue) => new uvec4((uint)random.Next((int)maxValue));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 Random(Random random, uvec4 minValue, uvec4 maxValue) => new uvec4((uint)random.Next((int)minValue.x, (int)maxValue.x), (uint)random.Next((int)minValue.y, (int)maxValue.y), (uint)random.Next((int)minValue.z, (int)maxValue.z), (uint)random.Next((int)minValue.w, (int)maxValue.w));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 Random(Random random, uvec4 minValue, uint maxValue) => new uvec4((uint)random.Next((int)minValue.x, (int)maxValue), (uint)random.Next((int)minValue.y, (int)maxValue), (uint)random.Next((int)minValue.z, (int)maxValue), (uint)random.Next((int)minValue.w, (int)maxValue));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 Random(Random random, uint minValue, uvec4 maxValue) => new uvec4((uint)random.Next((int)minValue, (int)maxValue.x), (uint)random.Next((int)minValue, (int)maxValue.y), (uint)random.Next((int)minValue, (int)maxValue.z), (uint)random.Next((int)minValue, (int)maxValue.w));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 Random(Random random, uint minValue, uint maxValue) => new uvec4((uint)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 RandomUniform(Random random, uvec4 minValue, uvec4 maxValue) => new uvec4((uint)random.Next((int)minValue.x, (int)maxValue.x), (uint)random.Next((int)minValue.y, (int)maxValue.y), (uint)random.Next((int)minValue.z, (int)maxValue.z), (uint)random.Next((int)minValue.w, (int)maxValue.w));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 RandomUniform(Random random, uvec4 minValue, uint maxValue) => new uvec4((uint)random.Next((int)minValue.x, (int)maxValue), (uint)random.Next((int)minValue.y, (int)maxValue), (uint)random.Next((int)minValue.z, (int)maxValue), (uint)random.Next((int)minValue.w, (int)maxValue));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 RandomUniform(Random random, uint minValue, uvec4 maxValue) => new uvec4((uint)random.Next((int)minValue, (int)maxValue.x), (uint)random.Next((int)minValue, (int)maxValue.y), (uint)random.Next((int)minValue, (int)maxValue.z), (uint)random.Next((int)minValue, (int)maxValue.w));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 RandomUniform(Random random, uint minValue, uint maxValue) => new uvec4((uint)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static uvec4 RandomPoisson(Random random, dvec4 lambda) => new uvec4((uint)lambda.x.GetPoisson(random), (uint)lambda.y.GetPoisson(random), (uint)lambda.z.GetPoisson(random), (uint)lambda.w.GetPoisson(random));
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static uvec4 RandomPoisson(Random random, double lambda) => new uvec4((uint)lambda.GetPoisson(random));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(uvec4 lhs, uint rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(uint lhs, uvec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(uvec4 lhs, uint rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(uint lhs, uvec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(uvec4 lhs, uint rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(uint lhs, uvec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(uvec4 lhs, uvec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(uvec4 lhs, uint rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(uint lhs, uvec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uvec4 operator+(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uvec4 operator+(uvec4 lhs, uint rhs) => new uvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uvec4 operator+(uint lhs, uvec4 rhs) => new uvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uvec4 operator-(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uvec4 operator-(uvec4 lhs, uint rhs) => new uvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uvec4 operator-(uint lhs, uvec4 rhs) => new uvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uvec4 operator*(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uvec4 operator*(uvec4 lhs, uint rhs) => new uvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uvec4 operator*(uint lhs, uvec4 rhs) => new uvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uvec4 operator/(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uvec4 operator/(uvec4 lhs, uint rhs) => new uvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uvec4 operator/(uint lhs, uvec4 rhs) => new uvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator+ (identity).
        /// </summary>
        public static uvec4 operator+(uvec4 v) => v;
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator~ (~v).
        /// </summary>
        public static uvec4 operator~(uvec4 v) => new uvec4(~v.x, ~v.y, ~v.z, ~v.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uvec4 operator^(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uvec4 operator^(uvec4 lhs, uint rhs) => new uvec4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uvec4 operator^(uint lhs, uvec4 rhs) => new uvec4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uvec4 operator|(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uvec4 operator|(uvec4 lhs, uint rhs) => new uvec4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uvec4 operator|(uint lhs, uvec4 rhs) => new uvec4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uvec4 operator&(uvec4 lhs, uvec4 rhs) => new uvec4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uvec4 operator&(uvec4 lhs, uint rhs) => new uvec4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uvec4 operator&(uint lhs, uvec4 rhs) => new uvec4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec4 operator<<(uvec4 lhs, int rhs) => new uvec4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec4 operator>>(uvec4 lhs, int rhs) => new uvec4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);

        #endregion

    }
}
