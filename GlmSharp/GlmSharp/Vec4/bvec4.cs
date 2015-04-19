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
    /// A vector of type bool with 4 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct bvec4 : IReadOnlyList<bool>, IEquatable<bvec4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public bool z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public bool w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bvec4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public bvec4(bool v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = false;
            this.w = false;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec2 v, bool z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = false;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public bvec4(bvec2 v, bool z, bool w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = false;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public bvec4(bvec3 v, bool w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public bvec4(bvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec4(IReadOnlyList<bool> v)
        {
            var c = v.Count;
            this.x = c < 0 ? false : v[0];
            this.y = c < 1 ? false : v[1];
            this.z = c < 2 ? false : v[2];
            this.w = c < 3 ? false : v[3];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec4(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? false : (bool)v[0];
            this.y = c < 1 ? false : (bool)v[1];
            this.z = c < 2 ? false : (bool)v[2];
            this.w = c < 3 ? false : (bool)v[3];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec4(bool[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? false : v[0];
            this.y = c < 1 ? false : v[1];
            this.z = c < 2 ? false : v[2];
            this.w = c < 3 ? false : v[3];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec4(bool[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? false : v[0 + startIndex];
            this.y = c + startIndex < 1 ? false : v[1 + startIndex];
            this.z = c + startIndex < 2 ? false : v[2 + startIndex];
            this.w = c + startIndex < 3 ? false : v[3 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec4(IEnumerable<bool> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(bvec4 v) => new ivec2(v.x ? 1 : 0, v.y ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(bvec4 v) => new ivec3(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(bvec4 v) => new ivec4(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(bvec4 v) => new uvec2(v.x ? 1u : 0u, v.y ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(bvec4 v) => new uvec3(v.x ? 1u : 0u, v.y ? 1u : 0u, v.z ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(bvec4 v) => new uvec4(v.x ? 1u : 0u, v.y ? 1u : 0u, v.z ? 1u : 0u, v.w ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(bvec4 v) => new vec2(v.x ? 1f : 0f, v.y ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(bvec4 v) => new vec3(v.x ? 1f : 0f, v.y ? 1f : 0f, v.z ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(bvec4 v) => new vec4(v.x ? 1f : 0f, v.y ? 1f : 0f, v.z ? 1f : 0f, v.w ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(bvec4 v) => new hvec2(v.x ? Half.One : Half.Zero, v.y ? Half.One : Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(bvec4 v) => new hvec3(v.x ? Half.One : Half.Zero, v.y ? Half.One : Half.Zero, v.z ? Half.One : Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(bvec4 v) => new hvec4(v.x ? Half.One : Half.Zero, v.y ? Half.One : Half.Zero, v.z ? Half.One : Half.Zero, v.w ? Half.One : Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(bvec4 v) => new dvec2(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(bvec4 v) => new dvec3(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, v.z ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(bvec4 v) => new dvec4(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, v.z ? 1.0 : 0.0, v.w ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(bvec4 v) => new decvec2(v.x ? 1m : 0m, v.y ? 1m : 0m);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(bvec4 v) => new decvec3(v.x ? 1m : 0m, v.y ? 1m : 0m, v.z ? 1m : 0m);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(bvec4 v) => new decvec4(v.x ? 1m : 0m, v.y ? 1m : 0m, v.z ? 1m : 0m, v.w ? 1m : 0m);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(bvec4 v) => new cvec2(v.x ? Complex.One : Complex.Zero, v.y ? Complex.One : Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(bvec4 v) => new cvec3(v.x ? Complex.One : Complex.Zero, v.y ? Complex.One : Complex.Zero, v.z ? Complex.One : Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(bvec4 v) => new cvec4(v.x ? Complex.One : Complex.Zero, v.y ? Complex.One : Complex.Zero, v.z ? Complex.One : Complex.Zero, v.w ? Complex.One : Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(bvec4 v) => new lvec2(v.x ? 1 : 0, v.y ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(bvec4 v) => new lvec3(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(bvec4 v) => new lvec4(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(bvec4 v) => new bvec2((bool)v.x, (bool)v.y);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(bvec4 v) => new bvec3((bool)v.x, (bool)v.y, (bool)v.z);
        
        /// <summary>
        /// Explicitly converts this to a bool array.
        /// </summary>
        public static explicit operator bool[](bvec4 v) => new [] { v.x, v.y, v.z, v.w };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](bvec4 v) => new Object[] { v.x, v.y, v.z, v.w };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int index]
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
        public swizzle_bvec4 swizzle => new swizzle_bvec4(x, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public bvec2 xy
        {
            get
            {
                return new bvec2(x, y);
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
        public bvec2 xz
        {
            get
            {
                return new bvec2(x, z);
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
        public bvec2 yz
        {
            get
            {
                return new bvec2(y, z);
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
        public bvec3 xyz
        {
            get
            {
                return new bvec3(x, y, z);
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
        public bvec2 xw
        {
            get
            {
                return new bvec2(x, w);
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
        public bvec2 yw
        {
            get
            {
                return new bvec2(y, w);
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
        public bvec3 xyw
        {
            get
            {
                return new bvec3(x, y, w);
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
        public bvec2 zw
        {
            get
            {
                return new bvec2(z, w);
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
        public bvec3 xzw
        {
            get
            {
                return new bvec3(x, z, w);
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
        public bvec3 yzw
        {
            get
            {
                return new bvec3(y, z, w);
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
        public bvec4 xyzw
        {
            get
            {
                return new bvec4(x, y, z, w);
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
        public bvec2 rg
        {
            get
            {
                return new bvec2(x, y);
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
        public bvec2 rb
        {
            get
            {
                return new bvec2(x, z);
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
        public bvec2 gb
        {
            get
            {
                return new bvec2(y, z);
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
        public bvec3 rgb
        {
            get
            {
                return new bvec3(x, y, z);
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
        public bvec2 ra
        {
            get
            {
                return new bvec2(x, w);
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
        public bvec2 ga
        {
            get
            {
                return new bvec2(y, w);
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
        public bvec3 rga
        {
            get
            {
                return new bvec3(x, y, w);
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
        public bvec2 ba
        {
            get
            {
                return new bvec2(z, w);
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
        public bvec3 rba
        {
            get
            {
                return new bvec3(x, z, w);
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
        public bvec3 gba
        {
            get
            {
                return new bvec3(y, z, w);
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
        public bvec4 rgba
        {
            get
            {
                return new bvec4(x, y, z, w);
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
        public bool r
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
        public bool g
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
        public bool b
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
        public bool a
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
        public bool[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public bool MinElement => ((x && y) && (z && w));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public bool MaxElement => ((x || y) || (z || w));
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => ((x && y) && (z && w));
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => ((x || y) || (z || w));

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static bvec4 Zero { get; } = new bvec4(false, false, false, false);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static bvec4 Ones { get; } = new bvec4(true, true, true, true);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static bvec4 UnitX { get; } = new bvec4(true, false, false, false);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static bvec4 UnitY { get; } = new bvec4(false, true, false, false);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static bvec4 UnitZ { get; } = new bvec4(false, false, true, false);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static bvec4 UnitW { get; } = new bvec4(false, false, false, true);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(bvec4 lhs, bvec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(bvec4 lhs, bvec4 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
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
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bvec4 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bvec4 && Equals((bvec4) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((x.GetHashCode()) * 2) ^ y.GetHashCode()) * 2) ^ z.GetHashCode()) * 2) ^ w.GetHashCode();
            }
        }

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static bvec4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static bvec4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new bvec4(bool.Parse(kvp[0].Trim()), bool.Parse(kvp[1].Trim()), bool.Parse(kvp[2].Trim()), bool.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out bvec4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out bvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            bool x = false, y = false, z = false, w = false;
            var ok = ((bool.TryParse(kvp[0].Trim(), out x) && bool.TryParse(kvp[1].Trim(), out y)) && (bool.TryParse(kvp[2].Trim(), out z) && bool.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new bvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns a bvec4 with independent and identically distributed random true/false values (the probability for 'true' can be configured).
        /// </summary>
        public static bvec4 Random(Random random, float trueProbability = 0.5f) => new bvec4(random.NextDouble() < trueProbability, random.NextDouble() < trueProbability, random.NextDouble() < trueProbability, random.NextDouble() < trueProbability);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bvec4 lhs, bool rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bool lhs, bvec4 rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bool lhs, bool rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bvec4 lhs, bool rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bool lhs, bvec4 rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bool lhs, bool rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Not (!v).
        /// </summary>
        public static bvec4 Not(bvec4 v) => new bvec4(!v.x, !v.y, !v.z, !v.w);
        
        /// <summary>
        /// Returns a bvec from the application of Not (!v).
        /// </summary>
        public static bvec4 Not(bool v) => new bvec4(!v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec4 And(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z, lhs.w && rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec4 And(bvec4 lhs, bool rhs) => new bvec4(lhs.x && rhs, lhs.y && rhs, lhs.z && rhs, lhs.w && rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec4 And(bool lhs, bvec4 rhs) => new bvec4(lhs && rhs.x, lhs && rhs.y, lhs && rhs.z, lhs && rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec4 And(bool lhs, bool rhs) => new bvec4(lhs && rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec4 Nand(bvec4 lhs, bvec4 rhs) => new bvec4(!(lhs.x && rhs.x), !(lhs.y && rhs.y), !(lhs.z && rhs.z), !(lhs.w && rhs.w));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec4 Nand(bvec4 lhs, bool rhs) => new bvec4(!(lhs.x && rhs), !(lhs.y && rhs), !(lhs.z && rhs), !(lhs.w && rhs));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec4 Nand(bool lhs, bvec4 rhs) => new bvec4(!(lhs && rhs.x), !(lhs && rhs.y), !(lhs && rhs.z), !(lhs && rhs.w));
        
        /// <summary>
        /// Returns a bvec from the application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec4 Nand(bool lhs, bool rhs) => new bvec4(!(lhs && rhs));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec4 Or(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z, lhs.w || rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec4 Or(bvec4 lhs, bool rhs) => new bvec4(lhs.x || rhs, lhs.y || rhs, lhs.z || rhs, lhs.w || rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec4 Or(bool lhs, bvec4 rhs) => new bvec4(lhs || rhs.x, lhs || rhs.y, lhs || rhs.z, lhs || rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Or (lhs || rhs).
        /// </summary>
        public static bvec4 Or(bool lhs, bool rhs) => new bvec4(lhs || rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec4 Nor(bvec4 lhs, bvec4 rhs) => new bvec4(!(lhs.x || rhs.x), !(lhs.y || rhs.y), !(lhs.z || rhs.z), !(lhs.w || rhs.w));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec4 Nor(bvec4 lhs, bool rhs) => new bvec4(!(lhs.x || rhs), !(lhs.y || rhs), !(lhs.z || rhs), !(lhs.w || rhs));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec4 Nor(bool lhs, bvec4 rhs) => new bvec4(!(lhs || rhs.x), !(lhs || rhs.y), !(lhs || rhs.z), !(lhs || rhs.w));
        
        /// <summary>
        /// Returns a bvec from the application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec4 Nor(bool lhs, bool rhs) => new bvec4(!(lhs || rhs));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec4 Xor(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec4 Xor(bvec4 lhs, bool rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec4 Xor(bool lhs, bvec4 rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Xor (lhs != rhs).
        /// </summary>
        public static bvec4 Xor(bool lhs, bool rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec4 Xnor(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec4 Xnor(bvec4 lhs, bool rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec4 Xnor(bool lhs, bvec4 rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec4 Xnor(bool lhs, bool rhs) => new bvec4(lhs == rhs);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator! (!v).
        /// </summary>
        public static bvec4 operator!(bvec4 v) => new bvec4(!v.x, !v.y, !v.z, !v.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec4 operator&(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z, lhs.w && rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec4 operator&(bvec4 lhs, bool rhs) => new bvec4(lhs.x && rhs, lhs.y && rhs, lhs.z && rhs, lhs.w && rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec4 operator&(bool lhs, bvec4 rhs) => new bvec4(lhs && rhs.x, lhs && rhs.y, lhs && rhs.z, lhs && rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bvec4 operator|(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z, lhs.w || rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bvec4 operator|(bvec4 lhs, bool rhs) => new bvec4(lhs.x || rhs, lhs.y || rhs, lhs.z || rhs, lhs.w || rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bvec4 operator|(bool lhs, bvec4 rhs) => new bvec4(lhs || rhs.x, lhs || rhs.y, lhs || rhs.z, lhs || rhs.w);

        #endregion

    }
}
