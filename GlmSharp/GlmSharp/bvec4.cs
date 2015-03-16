using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
    public struct bvec4 : IReadOnlyList<bool>, IEquatable<bvec4>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public bool z;
        
        /// <summary>
        /// w-component
        /// </summary>
        public bool w;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_bvec4 swizzle => new swizzle_bvec4(x, y, z, w);
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static bvec4 Zero { get; } = new bvec4(default(bool), default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static bvec4 Ones { get; } = new bvec4(true, true, true, true);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static bvec4 UnitX { get; } = new bvec4(true, default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static bvec4 UnitY { get; } = new bvec4(default(bool), true, default(bool), default(bool));
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static bvec4 UnitZ { get; } = new bvec4(default(bool), default(bool), true, default(bool));
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static bvec4 UnitW { get; } = new bvec4(default(bool), default(bool), default(bool), true);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public bool[] Values => new[] { x, y, z, w };
        
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
            this.z = default(bool);
            this.w = default(bool);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec2 v, bool z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = default(bool);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
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
            this.w = default(bool);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec3 v, bool w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(bvec4 v) => new ivec2(v.x ? 1 : default(int), v.y ? 1 : default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(bvec4 v) => new ivec3(v.x ? 1 : default(int), v.y ? 1 : default(int), v.z ? 1 : default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(bvec4 v) => new ivec4(v.x ? 1 : default(int), v.y ? 1 : default(int), v.z ? 1 : default(int), v.w ? 1 : default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(bvec4 v) => new uvec2(v.x ? 1 : default(uint), v.y ? 1 : default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(bvec4 v) => new uvec3(v.x ? 1 : default(uint), v.y ? 1 : default(uint), v.z ? 1 : default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(bvec4 v) => new uvec4(v.x ? 1 : default(uint), v.y ? 1 : default(uint), v.z ? 1 : default(uint), v.w ? 1 : default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(bvec4 v) => new vec2(v.x ? 1f : default(float), v.y ? 1f : default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(bvec4 v) => new vec3(v.x ? 1f : default(float), v.y ? 1f : default(float), v.z ? 1f : default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(bvec4 v) => new vec4(v.x ? 1f : default(float), v.y ? 1f : default(float), v.z ? 1f : default(float), v.w ? 1f : default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(bvec4 v) => new dvec2(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(bvec4 v) => new dvec3(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double), v.z ? 1.0 : default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(bvec4 v) => new dvec4(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double), v.z ? 1.0 : default(double), v.w ? 1.0 : default(double));
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(bvec4 v) => new decvec2(v.x ? 1m : default(decimal), v.y ? 1m : default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(bvec4 v) => new decvec3(v.x ? 1m : default(decimal), v.y ? 1m : default(decimal), v.z ? 1m : default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(bvec4 v) => new decvec4(v.x ? 1m : default(decimal), v.y ? 1m : default(decimal), v.z ? 1m : default(decimal), v.w ? 1m : default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(bvec4 v) => new cvec2(v.x ? 1.0 : default(Complex), v.y ? 1.0 : default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(bvec4 v) => new cvec3(v.x ? 1.0 : default(Complex), v.y ? 1.0 : default(Complex), v.z ? 1.0 : default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(bvec4 v) => new cvec4(v.x ? 1.0 : default(Complex), v.y ? 1.0 : default(Complex), v.z ? 1.0 : default(Complex), v.w ? 1.0 : default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(bvec4 v) => new lvec2(v.x ? 1 : default(long), v.y ? 1 : default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(bvec4 v) => new lvec3(v.x ? 1 : default(long), v.y ? 1 : default(long), v.z ? 1 : default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(bvec4 v) => new lvec4(v.x ? 1 : default(long), v.y ? 1 : default(long), v.z ? 1 : default(long), v.w ? 1 : default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(bvec4 v) => new bvec2((bool)v.x, (bool)v.y);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(bvec4 v) => new bvec3((bool)v.x, (bool)v.y, (bool)v.z);
        
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
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
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
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                    case 2: this.z = value; break;
                    case 3: this.w = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bvec4 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z) && w.Equals(rhs.w);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bvec4 && Equals((bvec4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bvec4 lhs, bvec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bvec4 lhs, bvec4 rhs) => !lhs.Equals(rhs);
        
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
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => x + sep + y + sep + z + sep + w;
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => x.ToString(provider) + sep + y.ToString(provider) + sep + z.ToString(provider) + sep + w.ToString(provider);
        
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
            bool x = default(bool), y = default(bool), z = default(bool), w = default(bool);
            var ok = bool.TryParse(kvp[0].Trim(), out x) && bool.TryParse(kvp[1].Trim(), out y) && bool.TryParse(kvp[2].Trim(), out z) && bool.TryParse(kvp[3].Trim(), out w);
            result = ok ? new bvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public bool MinElement => x && y && z && w;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public bool MaxElement => x || y || z || w;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => x && y && z && w;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => x || y || z || w;
        
        /// <summary>
        /// Executes a component-wise &amp;&amp;. (sorry for different overload but &amp;&amp; cannot be overloaded directly)
        /// </summary>
        public static bvec4 operator&(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z, lhs.w && rhs.w);
        
        /// <summary>
        /// Executes a component-wise ||. (sorry for different overload but || cannot be overloaded directly)
        /// </summary>
        public static bvec4 operator|(bvec4 lhs, bvec4 rhs) => new bvec4(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z, lhs.w || rhs.w);
    }
}
