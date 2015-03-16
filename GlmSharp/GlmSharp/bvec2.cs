using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    
    /// <summary>
    /// A vector of type bool with 2 components.
    /// </summary>
    [Serializable]
    public struct bvec2 : IReadOnlyList<bool>, IEquatable<bvec2>
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
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_bvec2 swizzle => new swizzle_bvec2(x, y);
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static bvec2 Zero { get; } = new bvec2(default(bool), default(bool));
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static bvec2 Ones { get; } = new bvec2(true, true);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static bvec2 UnitX { get; } = new bvec2(true, default(bool));
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static bvec2 UnitY { get; } = new bvec2(default(bool), true);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public bool[] Values => new[] { x, y };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bvec2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public bvec2(bool v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec2(bvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec2(bvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec2(bvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(bvec2 v) => new ivec2(v.x ? 1 : default(int), v.y ? 1 : default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec3(bvec2 v) => new ivec3(v.x ? 1 : default(int), v.y ? 1 : default(int), default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(bvec2 v) => new ivec4(v.x ? 1 : default(int), v.y ? 1 : default(int), default(int), default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(bvec2 v) => new uvec2(v.x ? 1 : default(uint), v.y ? 1 : default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec3(bvec2 v) => new uvec3(v.x ? 1 : default(uint), v.y ? 1 : default(uint), default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(bvec2 v) => new uvec4(v.x ? 1 : default(uint), v.y ? 1 : default(uint), default(uint), default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(bvec2 v) => new vec2(v.x ? 1f : default(float), v.y ? 1f : default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec3(bvec2 v) => new vec3(v.x ? 1f : default(float), v.y ? 1f : default(float), default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(bvec2 v) => new vec4(v.x ? 1f : default(float), v.y ? 1f : default(float), default(float), default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(bvec2 v) => new dvec2(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec3(bvec2 v) => new dvec3(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double), default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(bvec2 v) => new dvec4(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double), default(double), default(double));
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(bvec2 v) => new decvec2(v.x ? 1m : default(decimal), v.y ? 1m : default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a decvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec3(bvec2 v) => new decvec3(v.x ? 1m : default(decimal), v.y ? 1m : default(decimal), default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(bvec2 v) => new decvec4(v.x ? 1m : default(decimal), v.y ? 1m : default(decimal), default(decimal), default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(bvec2 v) => new cvec2(v.x ? 1.0 : default(Complex), v.y ? 1.0 : default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a cvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec3(bvec2 v) => new cvec3(v.x ? 1.0 : default(Complex), v.y ? 1.0 : default(Complex), default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(bvec2 v) => new cvec4(v.x ? 1.0 : default(Complex), v.y ? 1.0 : default(Complex), default(Complex), default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(bvec2 v) => new lvec2(v.x ? 1 : default(long), v.y ? 1 : default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec3(bvec2 v) => new lvec3(v.x ? 1 : default(long), v.y ? 1 : default(long), default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(bvec2 v) => new lvec4(v.x ? 1 : default(long), v.y ? 1 : default(long), default(long), default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec3(bvec2 v) => new bvec3((bool)v.x, (bool)v.y, default(bool));
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(bvec2 v) => new bvec4((bool)v.x, (bool)v.y, default(bool), default(bool));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
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
        public bool this[int index]
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
        public bool Equals(bvec2 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bvec2 && Equals((bvec2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bvec2 lhs, bvec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bvec2 lhs, bvec2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((x.GetHashCode()) * 2) ^ y.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => x + sep + y;
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => x.ToString(provider) + sep + y.ToString(provider);
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static bvec2 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static bvec2 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new bvec2(bool.Parse(kvp[0].Trim()), bool.Parse(kvp[1].Trim()));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out bvec2 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out bvec2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            bool x = default(bool), y = default(bool);
            var ok = bool.TryParse(kvp[0].Trim(), out x) && bool.TryParse(kvp[1].Trim(), out y);
            result = ok ? new bvec2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public bool MinElement => x && y;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public bool MaxElement => x || y;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => x && y;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => x || y;
        
        /// <summary>
        /// Executes a component-wise &amp;&amp;. (sorry for different overload but &amp;&amp; cannot be overloaded directly)
        /// </summary>
        public static bvec2 operator&(bvec2 lhs, bvec2 rhs) => new bvec2(lhs.x && rhs.x, lhs.y && rhs.y);
        
        /// <summary>
        /// Executes a component-wise ||. (sorry for different overload but || cannot be overloaded directly)
        /// </summary>
        public static bvec2 operator|(bvec2 lhs, bvec2 rhs) => new bvec2(lhs.x || rhs.x, lhs.y || rhs.y);
    }
}
