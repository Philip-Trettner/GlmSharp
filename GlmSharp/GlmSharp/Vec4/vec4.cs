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
    /// A vector of type float with 4 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct vec4 : IReadOnlyList<float>, IEquatable<vec4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public float z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public float w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public vec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public vec4(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0f;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public vec4(vec2 v, float z, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public vec4(vec3 v, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public vec4(vec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec4(IReadOnlyList<float> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
            this.z = c < 2 ? 0f : v[2];
            this.w = c < 3 ? 0f : v[3];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec4(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : (float)v[0];
            this.y = c < 1 ? 0f : (float)v[1];
            this.z = c < 2 ? 0f : (float)v[2];
            this.w = c < 3 ? 0f : (float)v[3];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec4(float[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
            this.z = c < 2 ? 0f : v[2];
            this.w = c < 3 ? 0f : v[3];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec4(float[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0f : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0f : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0f : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0f : v[3 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec4(IEnumerable<float> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a dvec4.
        /// </summary>
        public static implicit operator dvec4(vec4 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Implicitly converts this to a cvec4.
        /// </summary>
        public static implicit operator cvec4(vec4 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(vec4 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(vec4 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(vec4 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(vec4 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(vec4 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(vec4 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(vec4 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(vec4 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(vec4 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(vec4 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(vec4 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(vec4 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(vec4 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(vec4 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(vec4 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(vec4 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(vec4 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(vec4 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(vec4 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(vec4 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(vec4 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(vec4 v) => new bvec2(v.x != 0f, v.y != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(vec4 v) => new bvec3(v.x != 0f, v.y != 0f, v.z != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(vec4 v) => new bvec4(v.x != 0f, v.y != 0f, v.z != 0f, v.w != 0f);
        
        /// <summary>
        /// Explicitly converts this to a float array.
        /// </summary>
        public static explicit operator float[](vec4 v) => new [] { v.x, v.y, v.z, v.w };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](vec4 v) => new Object[] { v.x, v.y, v.z, v.w };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public float this[int index]
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
        public swizzle_vec4 swizzle => new swizzle_vec4(x, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec2 xy
        {
            get
            {
                return new vec2(x, y);
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
        public vec2 xz
        {
            get
            {
                return new vec2(x, z);
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
        public vec2 yz
        {
            get
            {
                return new vec2(y, z);
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
        public vec3 xyz
        {
            get
            {
                return new vec3(x, y, z);
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
        public vec2 xw
        {
            get
            {
                return new vec2(x, w);
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
        public vec2 yw
        {
            get
            {
                return new vec2(y, w);
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
        public vec3 xyw
        {
            get
            {
                return new vec3(x, y, w);
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
        public vec2 zw
        {
            get
            {
                return new vec2(z, w);
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
        public vec3 xzw
        {
            get
            {
                return new vec3(x, z, w);
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
        public vec3 yzw
        {
            get
            {
                return new vec3(y, z, w);
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
        public vec4 xyzw
        {
            get
            {
                return new vec4(x, y, z, w);
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
        public vec2 rg
        {
            get
            {
                return new vec2(x, y);
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
        public vec2 rb
        {
            get
            {
                return new vec2(x, z);
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
        public vec2 gb
        {
            get
            {
                return new vec2(y, z);
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
        public vec3 rgb
        {
            get
            {
                return new vec3(x, y, z);
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
        public vec2 ra
        {
            get
            {
                return new vec2(x, w);
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
        public vec2 ga
        {
            get
            {
                return new vec2(y, w);
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
        public vec3 rga
        {
            get
            {
                return new vec3(x, y, w);
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
        public vec2 ba
        {
            get
            {
                return new vec2(z, w);
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
        public vec3 rba
        {
            get
            {
                return new vec3(x, z, w);
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
        public vec3 gba
        {
            get
            {
                return new vec3(y, z, w);
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
        public vec4 rgba
        {
            get
            {
                return new vec4(x, y, z, w);
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
        public float r
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
        public float g
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
        public float b
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
        public float a
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
        public float[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public float MinElement => Math.Min(Math.Min(x, y), Math.Min(z, w));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public float MaxElement => Math.Max(Math.Max(x, y), Math.Max(z, w));
        
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
        public float Sum => ((x + y) + (z + w));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => ((Math.Abs(x) + Math.Abs(y)) + (Math.Abs(z) + Math.Abs(w)));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Max(Math.Abs(z), Math.Abs(w)));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public vec4 Normalized => this / (float)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public vec4 NormalizedSafe => this == Zero ? Zero : this / (float)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static vec4 Zero { get; } = new vec4(0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static vec4 Ones { get; } = new vec4(1f, 1f, 1f, 1f);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static vec4 UnitX { get; } = new vec4(1f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static vec4 UnitY { get; } = new vec4(0f, 1f, 0f, 0f);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static vec4 UnitZ { get; } = new vec4(0f, 0f, 1f, 0f);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static vec4 UnitW { get; } = new vec4(0f, 0f, 0f, 1f);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static vec4 MaxValue { get; } = new vec4(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static vec4 MinValue { get; } = new vec4(float.MinValue, float.MinValue, float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static vec4 Epsilon { get; } = new vec4(float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static vec4 NaN { get; } = new vec4(float.NaN, float.NaN, float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static vec4 NegativeInfinity { get; } = new vec4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static vec4 PositiveInfinity { get; } = new vec4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(vec4 lhs, vec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(vec4 lhs, vec4 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<float> GetEnumerator()
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
        public bool Equals(vec4 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is vec4 && Equals((vec4) obj);
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
        public static vec4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static vec4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new vec4(float.Parse(kvp[0].Trim()), float.Parse(kvp[1].Trim()), float.Parse(kvp[2].Trim()), float.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static vec4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new vec4(float.Parse(kvp[0].Trim(), provider), float.Parse(kvp[1].Trim(), provider), float.Parse(kvp[2].Trim(), provider), float.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static vec4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new vec4(float.Parse(kvp[0].Trim(), style), float.Parse(kvp[1].Trim(), style), float.Parse(kvp[2].Trim(), style), float.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static vec4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new vec4(float.Parse(kvp[0].Trim(), style, provider), float.Parse(kvp[1].Trim(), style, provider), float.Parse(kvp[2].Trim(), style, provider), float.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out vec4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out vec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            float x = 0f, y = 0f, z = 0f, w = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), out x) && float.TryParse(kvp[1].Trim(), out y)) && (float.TryParse(kvp[2].Trim(), out z) && float.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new vec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out vec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            float x = 0f, y = 0f, z = 0f, w = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), style, provider, out x) && float.TryParse(kvp[1].Trim(), style, provider, out y)) && (float.TryParse(kvp[2].Trim(), style, provider, out z) && float.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new vec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(vec4 lhs, vec4 rhs, float eps = 0.1f) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat4x2 OuterProduct(vec2 c, vec4 r) => new mat4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat2x4 OuterProduct(vec4 c, vec2 r) => new mat2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat4x3 OuterProduct(vec3 c, vec4 r) => new mat4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat3x4 OuterProduct(vec4 c, vec3 r) => new mat3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat4 OuterProduct(vec4 c, vec4 r) => new mat4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(vec4 lhs, vec4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(vec4 lhs, vec4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(vec4 lhs, vec4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec4 Reflect(vec4 I, vec4 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec4 Refract(vec4 I, vec4 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (float)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static vec4 FaceForward(vec4 N, vec4 I, vec4 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static vec4 Random(Random random) => new vec4((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static vec4 RandomSigned(Random random) => new vec4((float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static vec4 RandomNormal(Random random) => new vec4((float)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (float)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (float)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (float)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(vec4 lhs, vec4 rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(vec4 lhs, float rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(float lhs, vec4 rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(float lhs, float rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(vec4 lhs, vec4 rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(vec4 lhs, float rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(float lhs, vec4 rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(float lhs, float rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(vec4 lhs, vec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(vec4 lhs, float rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(float lhs, vec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(float lhs, float rhs) => new bvec4(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(vec4 lhs, vec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(vec4 lhs, float rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(float lhs, vec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(float lhs, float rhs) => new bvec4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(vec4 lhs, vec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(vec4 lhs, float rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(float lhs, vec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(float lhs, float rhs) => new bvec4(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(vec4 lhs, vec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(vec4 lhs, float rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(float lhs, vec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(float lhs, float rhs) => new bvec4(lhs <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(vec4 v) => new bvec4(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z), float.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(float v) => new bvec4(float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(vec4 v) => new bvec4(!float.IsNaN(v.x) && !float.IsInfinity(v.x), !float.IsNaN(v.y) && !float.IsInfinity(v.y), !float.IsNaN(v.z) && !float.IsInfinity(v.z), !float.IsNaN(v.w) && !float.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(float v) => new bvec4(!float.IsNaN(v) && !float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(vec4 v) => new bvec4(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z), float.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(float v) => new bvec4(float.IsNaN(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(vec4 v) => new bvec4(float.IsNegativeInfinity(v.x), float.IsNegativeInfinity(v.y), float.IsNegativeInfinity(v.z), float.IsNegativeInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(float v) => new bvec4(float.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(vec4 v) => new bvec4(float.IsPositiveInfinity(v.x), float.IsPositiveInfinity(v.y), float.IsPositiveInfinity(v.z), float.IsPositiveInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(float v) => new bvec4(float.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static vec4 Abs(vec4 v) => new vec4(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w));
        
        /// <summary>
        /// Returns a vec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static vec4 Abs(float v) => new vec4(Math.Abs(v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static vec4 HermiteInterpolationOrder3(vec4 v) => new vec4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a vec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static vec4 HermiteInterpolationOrder3(float v) => new vec4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static vec4 HermiteInterpolationOrder5(vec4 v) => new vec4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a vec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static vec4 HermiteInterpolationOrder5(float v) => new vec4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static vec4 Sqr(vec4 v) => new vec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a vec from the application of Sqr (v * v).
        /// </summary>
        public static vec4 Sqr(float v) => new vec4(v * v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static vec4 Pow2(vec4 v) => new vec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a vec from the application of Pow2 (v * v).
        /// </summary>
        public static vec4 Pow2(float v) => new vec4(v * v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static vec4 Pow3(vec4 v) => new vec4(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a vec from the application of Pow3 (v * v * v).
        /// </summary>
        public static vec4 Pow3(float v) => new vec4(v * v * v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static vec4 Step(vec4 v) => new vec4(v.x >= 0f ? 1f : 0f, v.y >= 0f ? 1f : 0f, v.z >= 0f ? 1f : 0f, v.w >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a vec from the application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static vec4 Step(float v) => new vec4(v >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static vec4 Sqrt(vec4 v) => new vec4((float)Math.Sqrt((double)v.x), (float)Math.Sqrt((double)v.y), (float)Math.Sqrt((double)v.z), (float)Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static vec4 Sqrt(float v) => new vec4((float)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static vec4 InverseSqrt(vec4 v) => new vec4((float)(1.0 / Math.Sqrt((double)v.x)), (float)(1.0 / Math.Sqrt((double)v.y)), (float)(1.0 / Math.Sqrt((double)v.z)), (float)(1.0 / Math.Sqrt((double)v.w)));
        
        /// <summary>
        /// Returns a vec from the application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static vec4 InverseSqrt(float v) => new vec4((float)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(vec4 v) => new ivec4(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(float v) => new ivec4(Math.Sign(v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec4 Max(vec4 lhs, vec4 rhs) => new vec4(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec4 Max(vec4 lhs, float rhs) => new vec4(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs), Math.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec4 Max(float lhs, vec4 rhs) => new vec4(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z), Math.Max(lhs, rhs.w));
        
        /// <summary>
        /// Returns a vec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec4 Max(float lhs, float rhs) => new vec4(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec4 Min(vec4 lhs, vec4 rhs) => new vec4(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec4 Min(vec4 lhs, float rhs) => new vec4(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs), Math.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec4 Min(float lhs, vec4 rhs) => new vec4(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z), Math.Min(lhs, rhs.w));
        
        /// <summary>
        /// Returns a vec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec4 Min(float lhs, float rhs) => new vec4(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Pow(vec4 lhs, vec4 rhs) => new vec4((float)Math.Pow((double)lhs.x, (double)rhs.x), (float)Math.Pow((double)lhs.y, (double)rhs.y), (float)Math.Pow((double)lhs.z, (double)rhs.z), (float)Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Pow(vec4 lhs, float rhs) => new vec4((float)Math.Pow((double)lhs.x, (double)rhs), (float)Math.Pow((double)lhs.y, (double)rhs), (float)Math.Pow((double)lhs.z, (double)rhs), (float)Math.Pow((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Pow(float lhs, vec4 rhs) => new vec4((float)Math.Pow((double)lhs, (double)rhs.x), (float)Math.Pow((double)lhs, (double)rhs.y), (float)Math.Pow((double)lhs, (double)rhs.z), (float)Math.Pow((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a vec from the application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Pow(float lhs, float rhs) => new vec4((float)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Log(vec4 lhs, vec4 rhs) => new vec4((float)Math.Log((double)lhs.x, (double)rhs.x), (float)Math.Log((double)lhs.y, (double)rhs.y), (float)Math.Log((double)lhs.z, (double)rhs.z), (float)Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Log(vec4 lhs, float rhs) => new vec4((float)Math.Log((double)lhs.x, (double)rhs), (float)Math.Log((double)lhs.y, (double)rhs), (float)Math.Log((double)lhs.z, (double)rhs), (float)Math.Log((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Log(float lhs, vec4 rhs) => new vec4((float)Math.Log((double)lhs, (double)rhs.x), (float)Math.Log((double)lhs, (double)rhs.y), (float)Math.Log((double)lhs, (double)rhs.z), (float)Math.Log((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a vec from the application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Log(float lhs, float rhs) => new vec4((float)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(vec4 v, vec4 min, vec4 max) => new vec4(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(vec4 v, vec4 min, float max) => new vec4(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(vec4 v, float min, vec4 max) => new vec4(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(vec4 v, float min, float max) => new vec4(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(float v, vec4 min, vec4 max) => new vec4(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(float v, vec4 min, float max) => new vec4(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(float v, float min, vec4 max) => new vec4(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a vec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(float v, float min, float max) => new vec4(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(vec4 min, vec4 max, vec4 a) => new vec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(vec4 min, vec4 max, float a) => new vec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(vec4 min, float max, vec4 a) => new vec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(vec4 min, float max, float a) => new vec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(float min, vec4 max, vec4 a) => new vec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(float min, vec4 max, float a) => new vec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(float min, float max, vec4 a) => new vec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a vec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(float min, float max, float a) => new vec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(vec4 min, vec4 max, vec4 a) => new vec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(vec4 min, vec4 max, float a) => new vec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(vec4 min, float max, vec4 a) => new vec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(vec4 min, float max, float a) => new vec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(float min, vec4 max, vec4 a) => new vec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(float min, vec4 max, float a) => new vec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(float min, float max, vec4 a) => new vec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a vec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(float min, float max, float a) => new vec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, vec4 edge1, vec4 v) => new vec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, vec4 edge1, float v) => new vec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, float edge1, vec4 v) => new vec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, float edge1, float v) => new vec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(float edge0, vec4 edge1, vec4 v) => new vec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(float edge0, vec4 edge1, float v) => new vec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(float edge0, float edge1, vec4 v) => new vec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(float edge0, float edge1, float v) => new vec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, vec4 edge1, vec4 v) => new vec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, vec4 edge1, float v) => new vec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, float edge1, vec4 v) => new vec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, float edge1, float v) => new vec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(float edge0, vec4 edge1, vec4 v) => new vec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(float edge0, vec4 edge1, float v) => new vec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(float edge0, float edge1, vec4 v) => new vec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(float edge0, float edge1, float v) => new vec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(vec4 a, vec4 b, vec4 c) => new vec4(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(vec4 a, vec4 b, float c) => new vec4(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(vec4 a, float b, vec4 c) => new vec4(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(vec4 a, float b, float c) => new vec4(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(float a, vec4 b, vec4 c) => new vec4(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(float a, vec4 b, float c) => new vec4(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(float a, float b, vec4 c) => new vec4(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w);
        
        /// <summary>
        /// Returns a vec from the application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(float a, float b, float c) => new vec4(a * b + c);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec4 Add(vec4 lhs, vec4 rhs) => new vec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec4 Add(vec4 lhs, float rhs) => new vec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec4 Add(float lhs, vec4 rhs) => new vec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a vec from the application of Add (lhs + rhs).
        /// </summary>
        public static vec4 Add(float lhs, float rhs) => new vec4(lhs + rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec4 Sub(vec4 lhs, vec4 rhs) => new vec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec4 Sub(vec4 lhs, float rhs) => new vec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec4 Sub(float lhs, vec4 rhs) => new vec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a vec from the application of Sub (lhs - rhs).
        /// </summary>
        public static vec4 Sub(float lhs, float rhs) => new vec4(lhs - rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec4 Mul(vec4 lhs, vec4 rhs) => new vec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec4 Mul(vec4 lhs, float rhs) => new vec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec4 Mul(float lhs, vec4 rhs) => new vec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a vec from the application of Mul (lhs * rhs).
        /// </summary>
        public static vec4 Mul(float lhs, float rhs) => new vec4(lhs * rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec4 Div(vec4 lhs, vec4 rhs) => new vec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec4 Div(vec4 lhs, float rhs) => new vec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec4 Div(float lhs, vec4 rhs) => new vec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a vec from the application of Div (lhs / rhs).
        /// </summary>
        public static vec4 Div(float lhs, float rhs) => new vec4(lhs / rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec4 Modulo(vec4 lhs, vec4 rhs) => new vec4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec4 Modulo(vec4 lhs, float rhs) => new vec4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec4 Modulo(float lhs, vec4 rhs) => new vec4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);
        
        /// <summary>
        /// Returns a vec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static vec4 Modulo(float lhs, float rhs) => new vec4(lhs % rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static vec4 Degrees(vec4 v) => new vec4((float)(v.x * 57.295779513082320876798154814105170332405472466564321f), (float)(v.y * 57.295779513082320876798154814105170332405472466564321f), (float)(v.z * 57.295779513082320876798154814105170332405472466564321f), (float)(v.w * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a vec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static vec4 Degrees(float v) => new vec4((float)(v * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static vec4 Radians(vec4 v) => new vec4((float)(v.x * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.y * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.z * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.w * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a vec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static vec4 Radians(float v) => new vec4((float)(v * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static vec4 Acos(vec4 v) => new vec4((float)Math.Acos((double)v.x), (float)Math.Acos((double)v.y), (float)Math.Acos((double)v.z), (float)Math.Acos((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static vec4 Acos(float v) => new vec4((float)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static vec4 Asin(vec4 v) => new vec4((float)Math.Asin((double)v.x), (float)Math.Asin((double)v.y), (float)Math.Asin((double)v.z), (float)Math.Asin((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static vec4 Asin(float v) => new vec4((float)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static vec4 Atan(vec4 v) => new vec4((float)Math.Atan((double)v.x), (float)Math.Atan((double)v.y), (float)Math.Atan((double)v.z), (float)Math.Atan((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static vec4 Atan(float v) => new vec4((float)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static vec4 Cos(vec4 v) => new vec4((float)Math.Cos((double)v.x), (float)Math.Cos((double)v.y), (float)Math.Cos((double)v.z), (float)Math.Cos((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static vec4 Cos(float v) => new vec4((float)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static vec4 Cosh(vec4 v) => new vec4((float)Math.Cosh((double)v.x), (float)Math.Cosh((double)v.y), (float)Math.Cosh((double)v.z), (float)Math.Cosh((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static vec4 Cosh(float v) => new vec4((float)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static vec4 Exp(vec4 v) => new vec4((float)Math.Exp((double)v.x), (float)Math.Exp((double)v.y), (float)Math.Exp((double)v.z), (float)Math.Exp((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static vec4 Exp(float v) => new vec4((float)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static vec4 Log(vec4 v) => new vec4((float)Math.Log((double)v.x), (float)Math.Log((double)v.y), (float)Math.Log((double)v.z), (float)Math.Log((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static vec4 Log(float v) => new vec4((float)Math.Log((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static vec4 Log2(vec4 v) => new vec4((float)Math.Log((double)v.x, 2), (float)Math.Log((double)v.y, 2), (float)Math.Log((double)v.z, 2), (float)Math.Log((double)v.w, 2));
        
        /// <summary>
        /// Returns a vec from the application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static vec4 Log2(float v) => new vec4((float)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static vec4 Log10(vec4 v) => new vec4((float)Math.Log10((double)v.x), (float)Math.Log10((double)v.y), (float)Math.Log10((double)v.z), (float)Math.Log10((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static vec4 Log10(float v) => new vec4((float)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static vec4 Floor(vec4 v) => new vec4((float)Math.Floor(v.x), (float)Math.Floor(v.y), (float)Math.Floor(v.z), (float)Math.Floor(v.w));
        
        /// <summary>
        /// Returns a vec from the application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static vec4 Floor(float v) => new vec4((float)Math.Floor(v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static vec4 Ceiling(vec4 v) => new vec4((float)Math.Ceiling(v.x), (float)Math.Ceiling(v.y), (float)Math.Ceiling(v.z), (float)Math.Ceiling(v.w));
        
        /// <summary>
        /// Returns a vec from the application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static vec4 Ceiling(float v) => new vec4((float)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Round ((float)Math.Round(v)).
        /// </summary>
        public static vec4 Round(vec4 v) => new vec4((float)Math.Round(v.x), (float)Math.Round(v.y), (float)Math.Round(v.z), (float)Math.Round(v.w));
        
        /// <summary>
        /// Returns a vec from the application of Round ((float)Math.Round(v)).
        /// </summary>
        public static vec4 Round(float v) => new vec4((float)Math.Round(v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static vec4 Sin(vec4 v) => new vec4((float)Math.Sin((double)v.x), (float)Math.Sin((double)v.y), (float)Math.Sin((double)v.z), (float)Math.Sin((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static vec4 Sin(float v) => new vec4((float)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static vec4 Sinh(vec4 v) => new vec4((float)Math.Sinh((double)v.x), (float)Math.Sinh((double)v.y), (float)Math.Sinh((double)v.z), (float)Math.Sinh((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static vec4 Sinh(float v) => new vec4((float)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static vec4 Tan(vec4 v) => new vec4((float)Math.Tan((double)v.x), (float)Math.Tan((double)v.y), (float)Math.Tan((double)v.z), (float)Math.Tan((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static vec4 Tan(float v) => new vec4((float)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static vec4 Tanh(vec4 v) => new vec4((float)Math.Tanh((double)v.x), (float)Math.Tanh((double)v.y), (float)Math.Tanh((double)v.z), (float)Math.Tanh((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static vec4 Tanh(float v) => new vec4((float)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static vec4 Truncate(vec4 v) => new vec4((float)Math.Truncate((double)v.x), (float)Math.Truncate((double)v.y), (float)Math.Truncate((double)v.z), (float)Math.Truncate((double)v.w));
        
        /// <summary>
        /// Returns a vec from the application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static vec4 Truncate(float v) => new vec4((float)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static vec4 Fract(vec4 v) => new vec4((float)(v.x - Math.Floor(v.x)), (float)(v.y - Math.Floor(v.y)), (float)(v.z - Math.Floor(v.z)), (float)(v.w - Math.Floor(v.w)));
        
        /// <summary>
        /// Returns a vec from the application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static vec4 Fract(float v) => new vec4((float)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static vec4 Trunc(vec4 v) => new vec4((long)(v.x), (long)(v.y), (long)(v.z), (long)(v.w));
        
        /// <summary>
        /// Returns a vec from the application of Trunc ((long)(v)).
        /// </summary>
        public static vec4 Trunc(float v) => new vec4((long)(v));
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 Random(Random random, vec4 minValue, vec4 maxValue) => new vec4((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (float)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 Random(Random random, vec4 minValue, float maxValue) => new vec4((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (float)random.NextDouble() * (maxValue - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 Random(Random random, float minValue, vec4 maxValue) => new vec4((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue, (float)random.NextDouble() * (maxValue.z - minValue) + minValue, (float)random.NextDouble() * (maxValue.w - minValue) + minValue);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 Random(Random random, float minValue, float maxValue) => new vec4((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 RandomUniform(Random random, vec4 minValue, vec4 maxValue) => new vec4((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (float)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 RandomUniform(Random random, vec4 minValue, float maxValue) => new vec4((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (float)random.NextDouble() * (maxValue - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 RandomUniform(Random random, float minValue, vec4 maxValue) => new vec4((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue, (float)random.NextDouble() * (maxValue.z - minValue) + minValue, (float)random.NextDouble() * (maxValue.w - minValue) + minValue);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 RandomUniform(Random random, float minValue, float maxValue) => new vec4((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomNormal(Random random, vec4 mean, vec4 variance) => new vec4((float)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (float)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (float)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (float)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomNormal(Random random, vec4 mean, float variance) => new vec4((float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomNormal(Random random, float mean, vec4 variance) => new vec4((float)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomNormal(Random random, float mean, float variance) => new vec4((float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomGaussian(Random random, vec4 mean, vec4 variance) => new vec4((float)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (float)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (float)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (float)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomGaussian(Random random, vec4 mean, float variance) => new vec4((float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomGaussian(Random random, float mean, vec4 variance) => new vec4((float)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomGaussian(Random random, float mean, float variance) => new vec4((float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(vec4 lhs, vec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(vec4 lhs, float rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(float lhs, vec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(vec4 lhs, vec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(vec4 lhs, float rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(float lhs, vec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(vec4 lhs, vec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(vec4 lhs, float rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(float lhs, vec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(vec4 lhs, vec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(vec4 lhs, float rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(float lhs, vec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static vec4 operator+(vec4 lhs, vec4 rhs) => new vec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static vec4 operator+(vec4 lhs, float rhs) => new vec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static vec4 operator+(float lhs, vec4 rhs) => new vec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static vec4 operator-(vec4 lhs, vec4 rhs) => new vec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static vec4 operator-(vec4 lhs, float rhs) => new vec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static vec4 operator-(float lhs, vec4 rhs) => new vec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static vec4 operator*(vec4 lhs, vec4 rhs) => new vec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static vec4 operator*(vec4 lhs, float rhs) => new vec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static vec4 operator*(float lhs, vec4 rhs) => new vec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static vec4 operator/(vec4 lhs, vec4 rhs) => new vec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static vec4 operator/(vec4 lhs, float rhs) => new vec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static vec4 operator/(float lhs, vec4 rhs) => new vec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator+ (identity).
        /// </summary>
        public static vec4 operator+(vec4 v) => v;
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator- (-v).
        /// </summary>
        public static vec4 operator-(vec4 v) => new vec4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static vec4 operator%(vec4 lhs, vec4 rhs) => new vec4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static vec4 operator%(vec4 lhs, float rhs) => new vec4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static vec4 operator%(float lhs, vec4 rhs) => new vec4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);

        #endregion

    }
}
