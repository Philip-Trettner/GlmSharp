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
    /// A vector of type double with 4 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct dvec4 : IReadOnlyList<double>, IEquatable<dvec4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public double y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public double z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public double w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dvec4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public dvec4(double v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0.0;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec2 v, double z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public dvec4(dvec2 v, double z, double w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public dvec4(dvec3 v, double w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public dvec4(dvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec4(IReadOnlyList<double> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
            this.z = c < 2 ? 0.0 : v[2];
            this.w = c < 3 ? 0.0 : v[3];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec4(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : (double)v[0];
            this.y = c < 1 ? 0.0 : (double)v[1];
            this.z = c < 2 ? 0.0 : (double)v[2];
            this.w = c < 3 ? 0.0 : (double)v[3];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec4(double[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
            this.z = c < 2 ? 0.0 : v[2];
            this.w = c < 3 ? 0.0 : v[3];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec4(double[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0.0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0.0 : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0.0 : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0.0 : v[3 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec4(IEnumerable<double> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a cvec4.
        /// </summary>
        public static implicit operator cvec4(dvec4 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(dvec4 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(dvec4 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(dvec4 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(dvec4 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(dvec4 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(dvec4 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(dvec4 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(dvec4 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(dvec4 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(dvec4 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(dvec4 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(dvec4 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(dvec4 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(dvec4 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(dvec4 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(dvec4 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(dvec4 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(dvec4 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(dvec4 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(dvec4 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(dvec4 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(dvec4 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(dvec4 v) => new bvec2(v.x != 0.0, v.y != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(dvec4 v) => new bvec3(v.x != 0.0, v.y != 0.0, v.z != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(dvec4 v) => new bvec4(v.x != 0.0, v.y != 0.0, v.z != 0.0, v.w != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a double array.
        /// </summary>
        public static explicit operator double[](dvec4 v) => new [] { v.x, v.y, v.z, v.w };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](dvec4 v) => new Object[] { v.x, v.y, v.z, v.w };

        #endregion


        #region Indexer
        
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
        public swizzle_dvec4 swizzle => new swizzle_dvec4(x, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public dvec2 xy
        {
            get
            {
                return new dvec2(x, y);
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
        public dvec2 xz
        {
            get
            {
                return new dvec2(x, z);
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
        public dvec2 yz
        {
            get
            {
                return new dvec2(y, z);
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
        public dvec3 xyz
        {
            get
            {
                return new dvec3(x, y, z);
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
        public dvec2 xw
        {
            get
            {
                return new dvec2(x, w);
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
        public dvec2 yw
        {
            get
            {
                return new dvec2(y, w);
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
        public dvec3 xyw
        {
            get
            {
                return new dvec3(x, y, w);
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
        public dvec2 zw
        {
            get
            {
                return new dvec2(z, w);
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
        public dvec3 xzw
        {
            get
            {
                return new dvec3(x, z, w);
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
        public dvec3 yzw
        {
            get
            {
                return new dvec3(y, z, w);
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
        public dvec4 xyzw
        {
            get
            {
                return new dvec4(x, y, z, w);
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
        public dvec2 rg
        {
            get
            {
                return new dvec2(x, y);
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
        public dvec2 rb
        {
            get
            {
                return new dvec2(x, z);
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
        public dvec2 gb
        {
            get
            {
                return new dvec2(y, z);
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
        public dvec3 rgb
        {
            get
            {
                return new dvec3(x, y, z);
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
        public dvec2 ra
        {
            get
            {
                return new dvec2(x, w);
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
        public dvec2 ga
        {
            get
            {
                return new dvec2(y, w);
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
        public dvec3 rga
        {
            get
            {
                return new dvec3(x, y, w);
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
        public dvec2 ba
        {
            get
            {
                return new dvec2(z, w);
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
        public dvec3 rba
        {
            get
            {
                return new dvec3(x, z, w);
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
        public dvec3 gba
        {
            get
            {
                return new dvec3(y, z, w);
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
        public dvec4 rgba
        {
            get
            {
                return new dvec4(x, y, z, w);
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
        public double r
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
        public double g
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
        public double b
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
        public double a
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
        public double[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public double MinElement => Math.Min(Math.Min(x, y), Math.Min(z, w));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public double MaxElement => Math.Max(Math.Max(x, y), Math.Max(z, w));
        
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
        public double Sum => ((x + y) + (z + w));
        
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
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public dvec4 Normalized => this / (double)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public dvec4 NormalizedSafe => this == Zero ? Zero : this / (double)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static dvec4 Zero { get; } = new dvec4(0.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static dvec4 Ones { get; } = new dvec4(1.0, 1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static dvec4 UnitX { get; } = new dvec4(1.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static dvec4 UnitY { get; } = new dvec4(0.0, 1.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static dvec4 UnitZ { get; } = new dvec4(0.0, 0.0, 1.0, 0.0);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static dvec4 UnitW { get; } = new dvec4(0.0, 0.0, 0.0, 1.0);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static dvec4 MaxValue { get; } = new dvec4(double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static dvec4 MinValue { get; } = new dvec4(double.MinValue, double.MinValue, double.MinValue, double.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static dvec4 Epsilon { get; } = new dvec4(double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static dvec4 NaN { get; } = new dvec4(double.NaN, double.NaN, double.NaN, double.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static dvec4 NegativeInfinity { get; } = new dvec4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static dvec4 PositiveInfinity { get; } = new dvec4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(dvec4 lhs, dvec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(dvec4 lhs, dvec4 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
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
        public bool Equals(dvec4 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is dvec4 && Equals((dvec4) obj);
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
        public static dvec4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static dvec4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new dvec4(double.Parse(kvp[0].Trim()), double.Parse(kvp[1].Trim()), double.Parse(kvp[2].Trim()), double.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static dvec4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new dvec4(double.Parse(kvp[0].Trim(), provider), double.Parse(kvp[1].Trim(), provider), double.Parse(kvp[2].Trim(), provider), double.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static dvec4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new dvec4(double.Parse(kvp[0].Trim(), style), double.Parse(kvp[1].Trim(), style), double.Parse(kvp[2].Trim(), style), double.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static dvec4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new dvec4(double.Parse(kvp[0].Trim(), style, provider), double.Parse(kvp[1].Trim(), style, provider), double.Parse(kvp[2].Trim(), style, provider), double.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out dvec4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out dvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            double x = 0.0, y = 0.0, z = 0.0, w = 0.0;
            var ok = ((double.TryParse(kvp[0].Trim(), out x) && double.TryParse(kvp[1].Trim(), out y)) && (double.TryParse(kvp[2].Trim(), out z) && double.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new dvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out dvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            double x = 0.0, y = 0.0, z = 0.0, w = 0.0;
            var ok = ((double.TryParse(kvp[0].Trim(), style, provider, out x) && double.TryParse(kvp[1].Trim(), style, provider, out y)) && (double.TryParse(kvp[2].Trim(), style, provider, out z) && double.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new dvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(dvec4 lhs, dvec4 rhs, double eps = 0.1d) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4x2 OuterProduct(dvec2 c, dvec4 r) => new dmat4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2x4 OuterProduct(dvec4 c, dvec2 r) => new dmat2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4x3 OuterProduct(dvec3 c, dvec4 r) => new dmat4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat3x4 OuterProduct(dvec4 c, dvec3 r) => new dmat3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4 OuterProduct(dvec4 c, dvec4 r) => new dmat4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec4 lhs, dvec4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec4 lhs, dvec4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec4 lhs, dvec4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec4 Reflect(dvec4 I, dvec4 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec4 Refract(dvec4 I, dvec4 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (double)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static dvec4 FaceForward(dvec4 N, dvec4 I, dvec4 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static dvec4 Random(Random random) => new dvec4((double)random.NextDouble(), (double)random.NextDouble(), (double)random.NextDouble(), (double)random.NextDouble());
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static dvec4 RandomSigned(Random random) => new dvec4((double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static dvec4 RandomNormal(Random random) => new dvec4((double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(dvec4 lhs, double rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(double lhs, dvec4 rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(double lhs, double rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(dvec4 lhs, double rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(double lhs, dvec4 rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(double lhs, double rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(dvec4 lhs, double rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(double lhs, dvec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(double lhs, double rhs) => new bvec4(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(dvec4 lhs, double rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(double lhs, dvec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(double lhs, double rhs) => new bvec4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(dvec4 lhs, double rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(double lhs, dvec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(double lhs, double rhs) => new bvec4(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(dvec4 lhs, double rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(double lhs, dvec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(double lhs, double rhs) => new bvec4(lhs <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(dvec4 v) => new bvec4(double.IsInfinity(v.x), double.IsInfinity(v.y), double.IsInfinity(v.z), double.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(double v) => new bvec4(double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(dvec4 v) => new bvec4(!double.IsNaN(v.x) && !double.IsInfinity(v.x), !double.IsNaN(v.y) && !double.IsInfinity(v.y), !double.IsNaN(v.z) && !double.IsInfinity(v.z), !double.IsNaN(v.w) && !double.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(double v) => new bvec4(!double.IsNaN(v) && !double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(dvec4 v) => new bvec4(double.IsNaN(v.x), double.IsNaN(v.y), double.IsNaN(v.z), double.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(double v) => new bvec4(double.IsNaN(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(dvec4 v) => new bvec4(double.IsNegativeInfinity(v.x), double.IsNegativeInfinity(v.y), double.IsNegativeInfinity(v.z), double.IsNegativeInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(double v) => new bvec4(double.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(dvec4 v) => new bvec4(double.IsPositiveInfinity(v.x), double.IsPositiveInfinity(v.y), double.IsPositiveInfinity(v.z), double.IsPositiveInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(double v) => new bvec4(double.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec4 Abs(dvec4 v) => new dvec4(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec4 Abs(double v) => new dvec4(Math.Abs(v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec4 HermiteInterpolationOrder3(dvec4 v) => new dvec4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a dvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec4 HermiteInterpolationOrder3(double v) => new dvec4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec4 HermiteInterpolationOrder5(dvec4 v) => new dvec4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a dvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec4 HermiteInterpolationOrder5(double v) => new dvec4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static dvec4 Sqr(dvec4 v) => new dvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a dvec from the application of Sqr (v * v).
        /// </summary>
        public static dvec4 Sqr(double v) => new dvec4(v * v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static dvec4 Pow2(dvec4 v) => new dvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a dvec from the application of Pow2 (v * v).
        /// </summary>
        public static dvec4 Pow2(double v) => new dvec4(v * v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static dvec4 Pow3(dvec4 v) => new dvec4(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a dvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static dvec4 Pow3(double v) => new dvec4(v * v * v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec4 Step(dvec4 v) => new dvec4(v.x >= 0.0 ? 1.0 : 0.0, v.y >= 0.0 ? 1.0 : 0.0, v.z >= 0.0 ? 1.0 : 0.0, v.w >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a dvec from the application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec4 Step(double v) => new dvec4(v >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec4 Sqrt(dvec4 v) => new dvec4((double)Math.Sqrt((double)v.x), (double)Math.Sqrt((double)v.y), (double)Math.Sqrt((double)v.z), (double)Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec4 Sqrt(double v) => new dvec4((double)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec4 InverseSqrt(dvec4 v) => new dvec4((double)(1.0 / Math.Sqrt((double)v.x)), (double)(1.0 / Math.Sqrt((double)v.y)), (double)(1.0 / Math.Sqrt((double)v.z)), (double)(1.0 / Math.Sqrt((double)v.w)));
        
        /// <summary>
        /// Returns a dvec from the application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec4 InverseSqrt(double v) => new dvec4((double)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(dvec4 v) => new ivec4(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(double v) => new ivec4(Math.Sign(v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec4 Max(dvec4 lhs, dvec4 rhs) => new dvec4(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec4 Max(dvec4 lhs, double rhs) => new dvec4(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs), Math.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec4 Max(double lhs, dvec4 rhs) => new dvec4(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z), Math.Max(lhs, rhs.w));
        
        /// <summary>
        /// Returns a dvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec4 Max(double lhs, double rhs) => new dvec4(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec4 Min(dvec4 lhs, dvec4 rhs) => new dvec4(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec4 Min(dvec4 lhs, double rhs) => new dvec4(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs), Math.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec4 Min(double lhs, dvec4 rhs) => new dvec4(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z), Math.Min(lhs, rhs.w));
        
        /// <summary>
        /// Returns a dvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec4 Min(double lhs, double rhs) => new dvec4(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Pow(dvec4 lhs, dvec4 rhs) => new dvec4((double)Math.Pow((double)lhs.x, (double)rhs.x), (double)Math.Pow((double)lhs.y, (double)rhs.y), (double)Math.Pow((double)lhs.z, (double)rhs.z), (double)Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Pow(dvec4 lhs, double rhs) => new dvec4((double)Math.Pow((double)lhs.x, (double)rhs), (double)Math.Pow((double)lhs.y, (double)rhs), (double)Math.Pow((double)lhs.z, (double)rhs), (double)Math.Pow((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Pow(double lhs, dvec4 rhs) => new dvec4((double)Math.Pow((double)lhs, (double)rhs.x), (double)Math.Pow((double)lhs, (double)rhs.y), (double)Math.Pow((double)lhs, (double)rhs.z), (double)Math.Pow((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a dvec from the application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Pow(double lhs, double rhs) => new dvec4((double)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Log(dvec4 lhs, dvec4 rhs) => new dvec4((double)Math.Log((double)lhs.x, (double)rhs.x), (double)Math.Log((double)lhs.y, (double)rhs.y), (double)Math.Log((double)lhs.z, (double)rhs.z), (double)Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Log(dvec4 lhs, double rhs) => new dvec4((double)Math.Log((double)lhs.x, (double)rhs), (double)Math.Log((double)lhs.y, (double)rhs), (double)Math.Log((double)lhs.z, (double)rhs), (double)Math.Log((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Log(double lhs, dvec4 rhs) => new dvec4((double)Math.Log((double)lhs, (double)rhs.x), (double)Math.Log((double)lhs, (double)rhs.y), (double)Math.Log((double)lhs, (double)rhs.z), (double)Math.Log((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a dvec from the application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Log(double lhs, double rhs) => new dvec4((double)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(dvec4 v, dvec4 min, dvec4 max) => new dvec4(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(dvec4 v, dvec4 min, double max) => new dvec4(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(dvec4 v, double min, dvec4 max) => new dvec4(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(dvec4 v, double min, double max) => new dvec4(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(double v, dvec4 min, dvec4 max) => new dvec4(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(double v, dvec4 min, double max) => new dvec4(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(double v, double min, dvec4 max) => new dvec4(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a dvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(double v, double min, double max) => new dvec4(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(dvec4 min, dvec4 max, dvec4 a) => new dvec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(dvec4 min, dvec4 max, double a) => new dvec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(dvec4 min, double max, dvec4 a) => new dvec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(dvec4 min, double max, double a) => new dvec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(double min, dvec4 max, dvec4 a) => new dvec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(double min, dvec4 max, double a) => new dvec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(double min, double max, dvec4 a) => new dvec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a dvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(double min, double max, double a) => new dvec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(dvec4 min, dvec4 max, dvec4 a) => new dvec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(dvec4 min, dvec4 max, double a) => new dvec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(dvec4 min, double max, dvec4 a) => new dvec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(dvec4 min, double max, double a) => new dvec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(double min, dvec4 max, dvec4 a) => new dvec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(double min, dvec4 max, double a) => new dvec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(double min, double max, dvec4 a) => new dvec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a dvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(double min, double max, double a) => new dvec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, dvec4 edge1, dvec4 v) => new dvec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, dvec4 edge1, double v) => new dvec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, double edge1, dvec4 v) => new dvec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, double edge1, double v) => new dvec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(double edge0, dvec4 edge1, dvec4 v) => new dvec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(double edge0, dvec4 edge1, double v) => new dvec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(double edge0, double edge1, dvec4 v) => new dvec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(double edge0, double edge1, double v) => new dvec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, dvec4 edge1, dvec4 v) => new dvec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, dvec4 edge1, double v) => new dvec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, double edge1, dvec4 v) => new dvec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, double edge1, double v) => new dvec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(double edge0, dvec4 edge1, dvec4 v) => new dvec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(double edge0, dvec4 edge1, double v) => new dvec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(double edge0, double edge1, dvec4 v) => new dvec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(double edge0, double edge1, double v) => new dvec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(dvec4 a, dvec4 b, dvec4 c) => new dvec4(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(dvec4 a, dvec4 b, double c) => new dvec4(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(dvec4 a, double b, dvec4 c) => new dvec4(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(dvec4 a, double b, double c) => new dvec4(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(double a, dvec4 b, dvec4 c) => new dvec4(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(double a, dvec4 b, double c) => new dvec4(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(double a, double b, dvec4 c) => new dvec4(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w);
        
        /// <summary>
        /// Returns a dvec from the application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(double a, double b, double c) => new dvec4(a * b + c);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec4 Add(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec4 Add(dvec4 lhs, double rhs) => new dvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec4 Add(double lhs, dvec4 rhs) => new dvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a dvec from the application of Add (lhs + rhs).
        /// </summary>
        public static dvec4 Add(double lhs, double rhs) => new dvec4(lhs + rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec4 Sub(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec4 Sub(dvec4 lhs, double rhs) => new dvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec4 Sub(double lhs, dvec4 rhs) => new dvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a dvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static dvec4 Sub(double lhs, double rhs) => new dvec4(lhs - rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec4 Mul(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec4 Mul(dvec4 lhs, double rhs) => new dvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec4 Mul(double lhs, dvec4 rhs) => new dvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a dvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static dvec4 Mul(double lhs, double rhs) => new dvec4(lhs * rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec4 Div(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec4 Div(dvec4 lhs, double rhs) => new dvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec4 Div(double lhs, dvec4 rhs) => new dvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a dvec from the application of Div (lhs / rhs).
        /// </summary>
        public static dvec4 Div(double lhs, double rhs) => new dvec4(lhs / rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec4 Modulo(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec4 Modulo(dvec4 lhs, double rhs) => new dvec4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec4 Modulo(double lhs, dvec4 rhs) => new dvec4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);
        
        /// <summary>
        /// Returns a dvec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec4 Modulo(double lhs, double rhs) => new dvec4(lhs % rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec4 Degrees(dvec4 v) => new dvec4((double)(v.x * 57.295779513082320876798154814105170332405472466564321d), (double)(v.y * 57.295779513082320876798154814105170332405472466564321d), (double)(v.z * 57.295779513082320876798154814105170332405472466564321d), (double)(v.w * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a dvec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec4 Degrees(double v) => new dvec4((double)(v * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec4 Radians(dvec4 v) => new dvec4((double)(v.x * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.y * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.z * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.w * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a dvec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec4 Radians(double v) => new dvec4((double)(v * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec4 Acos(dvec4 v) => new dvec4((double)Math.Acos((double)v.x), (double)Math.Acos((double)v.y), (double)Math.Acos((double)v.z), (double)Math.Acos((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec4 Acos(double v) => new dvec4((double)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec4 Asin(dvec4 v) => new dvec4((double)Math.Asin((double)v.x), (double)Math.Asin((double)v.y), (double)Math.Asin((double)v.z), (double)Math.Asin((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec4 Asin(double v) => new dvec4((double)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec4 Atan(dvec4 v) => new dvec4((double)Math.Atan((double)v.x), (double)Math.Atan((double)v.y), (double)Math.Atan((double)v.z), (double)Math.Atan((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec4 Atan(double v) => new dvec4((double)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec4 Cos(dvec4 v) => new dvec4((double)Math.Cos((double)v.x), (double)Math.Cos((double)v.y), (double)Math.Cos((double)v.z), (double)Math.Cos((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec4 Cos(double v) => new dvec4((double)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec4 Cosh(dvec4 v) => new dvec4((double)Math.Cosh((double)v.x), (double)Math.Cosh((double)v.y), (double)Math.Cosh((double)v.z), (double)Math.Cosh((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec4 Cosh(double v) => new dvec4((double)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec4 Exp(dvec4 v) => new dvec4((double)Math.Exp((double)v.x), (double)Math.Exp((double)v.y), (double)Math.Exp((double)v.z), (double)Math.Exp((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec4 Exp(double v) => new dvec4((double)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec4 Log(dvec4 v) => new dvec4((double)Math.Log((double)v.x), (double)Math.Log((double)v.y), (double)Math.Log((double)v.z), (double)Math.Log((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec4 Log(double v) => new dvec4((double)Math.Log((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec4 Log2(dvec4 v) => new dvec4((double)Math.Log((double)v.x, 2), (double)Math.Log((double)v.y, 2), (double)Math.Log((double)v.z, 2), (double)Math.Log((double)v.w, 2));
        
        /// <summary>
        /// Returns a dvec from the application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec4 Log2(double v) => new dvec4((double)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec4 Log10(dvec4 v) => new dvec4((double)Math.Log10((double)v.x), (double)Math.Log10((double)v.y), (double)Math.Log10((double)v.z), (double)Math.Log10((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec4 Log10(double v) => new dvec4((double)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec4 Floor(dvec4 v) => new dvec4((double)Math.Floor(v.x), (double)Math.Floor(v.y), (double)Math.Floor(v.z), (double)Math.Floor(v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec4 Floor(double v) => new dvec4((double)Math.Floor(v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec4 Ceiling(dvec4 v) => new dvec4((double)Math.Ceiling(v.x), (double)Math.Ceiling(v.y), (double)Math.Ceiling(v.z), (double)Math.Ceiling(v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec4 Ceiling(double v) => new dvec4((double)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec4 Round(dvec4 v) => new dvec4((double)Math.Round(v.x), (double)Math.Round(v.y), (double)Math.Round(v.z), (double)Math.Round(v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec4 Round(double v) => new dvec4((double)Math.Round(v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec4 Sin(dvec4 v) => new dvec4((double)Math.Sin((double)v.x), (double)Math.Sin((double)v.y), (double)Math.Sin((double)v.z), (double)Math.Sin((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec4 Sin(double v) => new dvec4((double)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec4 Sinh(dvec4 v) => new dvec4((double)Math.Sinh((double)v.x), (double)Math.Sinh((double)v.y), (double)Math.Sinh((double)v.z), (double)Math.Sinh((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec4 Sinh(double v) => new dvec4((double)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec4 Tan(dvec4 v) => new dvec4((double)Math.Tan((double)v.x), (double)Math.Tan((double)v.y), (double)Math.Tan((double)v.z), (double)Math.Tan((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec4 Tan(double v) => new dvec4((double)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec4 Tanh(dvec4 v) => new dvec4((double)Math.Tanh((double)v.x), (double)Math.Tanh((double)v.y), (double)Math.Tanh((double)v.z), (double)Math.Tanh((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec4 Tanh(double v) => new dvec4((double)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec4 Truncate(dvec4 v) => new dvec4((double)Math.Truncate((double)v.x), (double)Math.Truncate((double)v.y), (double)Math.Truncate((double)v.z), (double)Math.Truncate((double)v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec4 Truncate(double v) => new dvec4((double)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec4 Fract(dvec4 v) => new dvec4((double)(v.x - Math.Floor(v.x)), (double)(v.y - Math.Floor(v.y)), (double)(v.z - Math.Floor(v.z)), (double)(v.w - Math.Floor(v.w)));
        
        /// <summary>
        /// Returns a dvec from the application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec4 Fract(double v) => new dvec4((double)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static dvec4 Trunc(dvec4 v) => new dvec4((long)(v.x), (long)(v.y), (long)(v.z), (long)(v.w));
        
        /// <summary>
        /// Returns a dvec from the application of Trunc ((long)(v)).
        /// </summary>
        public static dvec4 Trunc(double v) => new dvec4((long)(v));
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 Random(Random random, dvec4 minValue, dvec4 maxValue) => new dvec4((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 Random(Random random, dvec4 minValue, double maxValue) => new dvec4((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 Random(Random random, double minValue, dvec4 maxValue) => new dvec4((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue, (double)random.NextDouble() * (maxValue.z - minValue) + minValue, (double)random.NextDouble() * (maxValue.w - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 Random(Random random, double minValue, double maxValue) => new dvec4((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 RandomUniform(Random random, dvec4 minValue, dvec4 maxValue) => new dvec4((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 RandomUniform(Random random, dvec4 minValue, double maxValue) => new dvec4((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 RandomUniform(Random random, double minValue, dvec4 maxValue) => new dvec4((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue, (double)random.NextDouble() * (maxValue.z - minValue) + minValue, (double)random.NextDouble() * (maxValue.w - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 RandomUniform(Random random, double minValue, double maxValue) => new dvec4((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomNormal(Random random, dvec4 mean, dvec4 variance) => new dvec4((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (double)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (double)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomNormal(Random random, dvec4 mean, double variance) => new dvec4((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomNormal(Random random, double mean, dvec4 variance) => new dvec4((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomNormal(Random random, double mean, double variance) => new dvec4((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomGaussian(Random random, dvec4 mean, dvec4 variance) => new dvec4((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (double)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (double)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomGaussian(Random random, dvec4 mean, double variance) => new dvec4((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomGaussian(Random random, double mean, dvec4 variance) => new dvec4((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomGaussian(Random random, double mean, double variance) => new dvec4((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(dvec4 lhs, double rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(double lhs, dvec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(dvec4 lhs, double rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(double lhs, dvec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(dvec4 lhs, double rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(double lhs, dvec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(dvec4 lhs, double rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(double lhs, dvec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec4 operator+(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec4 operator+(dvec4 lhs, double rhs) => new dvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec4 operator+(double lhs, dvec4 rhs) => new dvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec4 operator-(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec4 operator-(dvec4 lhs, double rhs) => new dvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec4 operator-(double lhs, dvec4 rhs) => new dvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec4 operator*(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec4 operator*(dvec4 lhs, double rhs) => new dvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec4 operator*(double lhs, dvec4 rhs) => new dvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec4 operator/(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec4 operator/(dvec4 lhs, double rhs) => new dvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec4 operator/(double lhs, dvec4 rhs) => new dvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator+ (identity).
        /// </summary>
        public static dvec4 operator+(dvec4 v) => v;
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator- (-v).
        /// </summary>
        public static dvec4 operator-(dvec4 v) => new dvec4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec4 operator%(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec4 operator%(dvec4 lhs, double rhs) => new dvec4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec4 operator%(double lhs, dvec4 rhs) => new dvec4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);

        #endregion

    }
}
