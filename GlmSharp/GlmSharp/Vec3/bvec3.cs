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
    /// A vector of type bool with 3 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct bvec3 : IReadOnlyList<bool>, IEquatable<bvec3>
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bvec3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public bvec3(bool v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec3(bvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = false;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public bvec3(bvec2 v, bool z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public bvec3(bvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public bvec3(bvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec3(IReadOnlyList<bool> v)
        {
            var c = v.Count;
            this.x = c < 0 ? false : v[0];
            this.y = c < 1 ? false : v[1];
            this.z = c < 2 ? false : v[2];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec3(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? false : (bool)v[0];
            this.y = c < 1 ? false : (bool)v[1];
            this.z = c < 2 ? false : (bool)v[2];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec3(bool[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? false : v[0];
            this.y = c < 1 ? false : v[1];
            this.z = c < 2 ? false : v[2];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec3(bool[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? false : v[0 + startIndex];
            this.y = c + startIndex < 1 ? false : v[1 + startIndex];
            this.z = c + startIndex < 2 ? false : v[2 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bvec3(IEnumerable<bool> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(bvec3 v) => new ivec2(v.x ? 1 : 0, v.y ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(bvec3 v) => new ivec3(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(bvec3 v) => new ivec4(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(bvec3 v) => new uvec2(v.x ? 1u : 0u, v.y ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(bvec3 v) => new uvec3(v.x ? 1u : 0u, v.y ? 1u : 0u, v.z ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(bvec3 v) => new uvec4(v.x ? 1u : 0u, v.y ? 1u : 0u, v.z ? 1u : 0u, 0u);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(bvec3 v) => new vec2(v.x ? 1f : 0f, v.y ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(bvec3 v) => new vec3(v.x ? 1f : 0f, v.y ? 1f : 0f, v.z ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(bvec3 v) => new vec4(v.x ? 1f : 0f, v.y ? 1f : 0f, v.z ? 1f : 0f, 0f);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(bvec3 v) => new hvec2(v.x ? Half.One : Half.Zero, v.y ? Half.One : Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(bvec3 v) => new hvec3(v.x ? Half.One : Half.Zero, v.y ? Half.One : Half.Zero, v.z ? Half.One : Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a hvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator hvec4(bvec3 v) => new hvec4(v.x ? Half.One : Half.Zero, v.y ? Half.One : Half.Zero, v.z ? Half.One : Half.Zero, Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(bvec3 v) => new dvec2(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(bvec3 v) => new dvec3(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, v.z ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(bvec3 v) => new dvec4(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, v.z ? 1.0 : 0.0, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(bvec3 v) => new decvec2(v.x ? 1m : 0m, v.y ? 1m : 0m);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(bvec3 v) => new decvec3(v.x ? 1m : 0m, v.y ? 1m : 0m, v.z ? 1m : 0m);
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(bvec3 v) => new decvec4(v.x ? 1m : 0m, v.y ? 1m : 0m, v.z ? 1m : 0m, 0m);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(bvec3 v) => new cvec2(v.x ? Complex.One : Complex.Zero, v.y ? Complex.One : Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(bvec3 v) => new cvec3(v.x ? Complex.One : Complex.Zero, v.y ? Complex.One : Complex.Zero, v.z ? Complex.One : Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(bvec3 v) => new cvec4(v.x ? Complex.One : Complex.Zero, v.y ? Complex.One : Complex.Zero, v.z ? Complex.One : Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(bvec3 v) => new lvec2(v.x ? 1 : 0, v.y ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(bvec3 v) => new lvec3(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(bvec3 v) => new lvec4(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(bvec3 v) => new bvec2((bool)v.x, (bool)v.y);
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(bvec3 v) => new bvec4((bool)v.x, (bool)v.y, (bool)v.z, false);
        
        /// <summary>
        /// Explicitly converts this to a bool array.
        /// </summary>
        public static explicit operator bool[](bvec3 v) => new [] { v.x, v.y, v.z };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](bvec3 v) => new Object[] { v.x, v.y, v.z };

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
        public swizzle_bvec3 swizzle => new swizzle_bvec3(x, y, z);
        
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
        /// Returns an array with all values
        /// </summary>
        public bool[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public bool MinElement => ((x && y) && z);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public bool MaxElement => ((x || y) || z);
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => ((x && y) && z);
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => ((x || y) || z);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static bvec3 Zero { get; } = new bvec3(false, false, false);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static bvec3 Ones { get; } = new bvec3(true, true, true);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static bvec3 UnitX { get; } = new bvec3(true, false, false);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static bvec3 UnitY { get; } = new bvec3(false, true, false);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static bvec3 UnitZ { get; } = new bvec3(false, false, true);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(bvec3 lhs, bvec3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(bvec3 lhs, bvec3 rhs) => !lhs.Equals(rhs);

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
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => ((x.ToString(provider) + sep + y.ToString(provider)) + sep + z.ToString(provider));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bvec3 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bvec3 && Equals((bvec3) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((x.GetHashCode()) * 2) ^ y.GetHashCode()) * 2) ^ z.GetHashCode();
            }
        }

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static bvec3 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static bvec3 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new bvec3(bool.Parse(kvp[0].Trim()), bool.Parse(kvp[1].Trim()), bool.Parse(kvp[2].Trim()));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out bvec3 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out bvec3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            bool x = false, y = false, z = false;
            var ok = ((bool.TryParse(kvp[0].Trim(), out x) && bool.TryParse(kvp[1].Trim(), out y)) && bool.TryParse(kvp[2].Trim(), out z));
            result = ok ? new bvec3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns a bvec3 with independent and identically distributed random true/false values (the probability for 'true' can be configured).
        /// </summary>
        public static bvec3 Random(Random random, float trueProbability = 0.5f) => new bvec3(random.NextDouble() < trueProbability, random.NextDouble() < trueProbability, random.NextDouble() < trueProbability);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(bvec3 lhs, bvec3 rhs) => new bvec3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(bvec3 lhs, bool rhs) => new bvec3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(bool lhs, bvec3 rhs) => new bvec3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(bool lhs, bool rhs) => new bvec3(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(bvec3 lhs, bvec3 rhs) => new bvec3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(bvec3 lhs, bool rhs) => new bvec3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(bool lhs, bvec3 rhs) => new bvec3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(bool lhs, bool rhs) => new bvec3(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Not (!v).
        /// </summary>
        public static bvec3 Not(bvec3 v) => new bvec3(!v.x, !v.y, !v.z);
        
        /// <summary>
        /// Returns a bvec from the application of Not (!v).
        /// </summary>
        public static bvec3 Not(bool v) => new bvec3(!v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec3 And(bvec3 lhs, bvec3 rhs) => new bvec3(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec3 And(bvec3 lhs, bool rhs) => new bvec3(lhs.x && rhs, lhs.y && rhs, lhs.z && rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec3 And(bool lhs, bvec3 rhs) => new bvec3(lhs && rhs.x, lhs && rhs.y, lhs && rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec3 And(bool lhs, bool rhs) => new bvec3(lhs && rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec3 Nand(bvec3 lhs, bvec3 rhs) => new bvec3(!(lhs.x && rhs.x), !(lhs.y && rhs.y), !(lhs.z && rhs.z));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec3 Nand(bvec3 lhs, bool rhs) => new bvec3(!(lhs.x && rhs), !(lhs.y && rhs), !(lhs.z && rhs));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec3 Nand(bool lhs, bvec3 rhs) => new bvec3(!(lhs && rhs.x), !(lhs && rhs.y), !(lhs && rhs.z));
        
        /// <summary>
        /// Returns a bvec from the application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec3 Nand(bool lhs, bool rhs) => new bvec3(!(lhs && rhs));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec3 Or(bvec3 lhs, bvec3 rhs) => new bvec3(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec3 Or(bvec3 lhs, bool rhs) => new bvec3(lhs.x || rhs, lhs.y || rhs, lhs.z || rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec3 Or(bool lhs, bvec3 rhs) => new bvec3(lhs || rhs.x, lhs || rhs.y, lhs || rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of Or (lhs || rhs).
        /// </summary>
        public static bvec3 Or(bool lhs, bool rhs) => new bvec3(lhs || rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec3 Nor(bvec3 lhs, bvec3 rhs) => new bvec3(!(lhs.x || rhs.x), !(lhs.y || rhs.y), !(lhs.z || rhs.z));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec3 Nor(bvec3 lhs, bool rhs) => new bvec3(!(lhs.x || rhs), !(lhs.y || rhs), !(lhs.z || rhs));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec3 Nor(bool lhs, bvec3 rhs) => new bvec3(!(lhs || rhs.x), !(lhs || rhs.y), !(lhs || rhs.z));
        
        /// <summary>
        /// Returns a bvec from the application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec3 Nor(bool lhs, bool rhs) => new bvec3(!(lhs || rhs));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec3 Xor(bvec3 lhs, bvec3 rhs) => new bvec3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec3 Xor(bvec3 lhs, bool rhs) => new bvec3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec3 Xor(bool lhs, bvec3 rhs) => new bvec3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of Xor (lhs != rhs).
        /// </summary>
        public static bvec3 Xor(bool lhs, bool rhs) => new bvec3(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec3 Xnor(bvec3 lhs, bvec3 rhs) => new bvec3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec3 Xnor(bvec3 lhs, bool rhs) => new bvec3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec3 Xnor(bool lhs, bvec3 rhs) => new bvec3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec3 Xnor(bool lhs, bool rhs) => new bvec3(lhs == rhs);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator! (!v).
        /// </summary>
        public static bvec3 operator!(bvec3 v) => new bvec3(!v.x, !v.y, !v.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec3 operator&(bvec3 lhs, bvec3 rhs) => new bvec3(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec3 operator&(bvec3 lhs, bool rhs) => new bvec3(lhs.x && rhs, lhs.y && rhs, lhs.z && rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec3 operator&(bool lhs, bvec3 rhs) => new bvec3(lhs && rhs.x, lhs && rhs.y, lhs && rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bvec3 operator|(bvec3 lhs, bvec3 rhs) => new bvec3(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bvec3 operator|(bvec3 lhs, bool rhs) => new bvec3(lhs.x || rhs, lhs.y || rhs, lhs.z || rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bvec3 operator|(bool lhs, bvec3 rhs) => new bvec3(lhs || rhs.x, lhs || rhs.y, lhs || rhs.z);

        #endregion

    }
}
