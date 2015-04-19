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
    /// A quaternion of type bool.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct bquat : IReadOnlyList<bool>, IEquatable<bquat>
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
        public bquat(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public bquat(bool v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// copy constructor
        /// </summary>
        public bquat(bquat q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)
        /// </summary>
        public bquat(bvec3 v, bool s)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = s;
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(bquat v) => new ivec4(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a iquat.
        /// </summary>
        public static explicit operator iquat(bquat v) => new iquat(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(bquat v) => new uvec4(v.x ? 1u : 0u, v.y ? 1u : 0u, v.z ? 1u : 0u, v.w ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a uquat.
        /// </summary>
        public static explicit operator uquat(bquat v) => new uquat(v.x ? 1u : 0u, v.y ? 1u : 0u, v.z ? 1u : 0u, v.w ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(bquat v) => new vec4(v.x ? 1f : 0f, v.y ? 1f : 0f, v.z ? 1f : 0f, v.w ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a quat.
        /// </summary>
        public static explicit operator quat(bquat v) => new quat(v.x ? 1f : 0f, v.y ? 1f : 0f, v.z ? 1f : 0f, v.w ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(bquat v) => new hvec4(v.x ? Half.One : Half.Zero, v.y ? Half.One : Half.Zero, v.z ? Half.One : Half.Zero, v.w ? Half.One : Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a hquat.
        /// </summary>
        public static explicit operator hquat(bquat v) => new hquat(v.x ? Half.One : Half.Zero, v.y ? Half.One : Half.Zero, v.z ? Half.One : Half.Zero, v.w ? Half.One : Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(bquat v) => new dvec4(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, v.z ? 1.0 : 0.0, v.w ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a dquat.
        /// </summary>
        public static explicit operator dquat(bquat v) => new dquat(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, v.z ? 1.0 : 0.0, v.w ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(bquat v) => new decvec4(v.x ? 1m : 0m, v.y ? 1m : 0m, v.z ? 1m : 0m, v.w ? 1m : 0m);
        
        /// <summary>
        /// Explicitly converts this to a decquat.
        /// </summary>
        public static explicit operator decquat(bquat v) => new decquat(v.x ? 1m : 0m, v.y ? 1m : 0m, v.z ? 1m : 0m, v.w ? 1m : 0m);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(bquat v) => new cvec4(v.x ? Complex.One : Complex.Zero, v.y ? Complex.One : Complex.Zero, v.z ? Complex.One : Complex.Zero, v.w ? Complex.One : Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a cquat.
        /// </summary>
        public static explicit operator cquat(bquat v) => new cquat(v.x ? Complex.One : Complex.Zero, v.y ? Complex.One : Complex.Zero, v.z ? Complex.One : Complex.Zero, v.w ? Complex.One : Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(bquat v) => new lvec4(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a lquat.
        /// </summary>
        public static explicit operator lquat(bquat v) => new lquat(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(bquat v) => new bvec4((bool)v.x, (bool)v.y, (bool)v.z, (bool)v.w);

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
        /// Returns an array with all values
        /// </summary>
        public bool[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this quaternion.
        /// </summary>
        public bool MinElement => ((x && y) && (z && w));
        
        /// <summary>
        /// Returns the maximal component of this quaternion.
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
        /// Predefined all-zero quaternion
        /// </summary>
        public static bquat Zero { get; } = new bquat(false, false, false, false);
        
        /// <summary>
        /// Predefined all-ones quaternion
        /// </summary>
        public static bquat Ones { get; } = new bquat(true, true, true, true);
        
        /// <summary>
        /// Predefined identity quaternion
        /// </summary>
        public static bquat Identity { get; } = new bquat(false, false, false, true);
        
        /// <summary>
        /// Predefined unit-X quaternion
        /// </summary>
        public static bquat UnitX { get; } = new bquat(true, false, false, false);
        
        /// <summary>
        /// Predefined unit-Y quaternion
        /// </summary>
        public static bquat UnitY { get; } = new bquat(false, true, false, false);
        
        /// <summary>
        /// Predefined unit-Z quaternion
        /// </summary>
        public static bquat UnitZ { get; } = new bquat(false, false, true, false);
        
        /// <summary>
        /// Predefined unit-W quaternion
        /// </summary>
        public static bquat UnitW { get; } = new bquat(false, false, false, true);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(bquat lhs, bquat rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(bquat lhs, bquat rhs) => !lhs.Equals(rhs);

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
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public string ToString(string sep) => ((x + sep + y) + sep + (z + sep + w));
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => ((x.ToString(provider) + sep + y.ToString(provider)) + sep + (z.ToString(provider) + sep + w.ToString(provider)));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bquat rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bquat && Equals((bquat) obj);
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
        /// Converts the string representation of the quaternion into a quaternion representation (using ', ' as a separator).
        /// </summary>
        public static bquat Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator).
        /// </summary>
        public static bquat Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new bquat(bool.Parse(kvp[0].Trim()), bool.Parse(kvp[1].Trim()), bool.Parse(kvp[2].Trim()), bool.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out bquat result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out bquat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            bool x = false, y = false, z = false, w = false;
            var ok = ((bool.TryParse(kvp[0].Trim(), out x) && bool.TryParse(kvp[1].Trim(), out y)) && (bool.TryParse(kvp[2].Trim(), out z) && bool.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new bquat(x, y, z, w) : Zero;
            return ok;
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bquat lhs, bquat rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bquat lhs, bool rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bool lhs, bquat rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bool lhs, bool rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bquat lhs, bquat rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bquat lhs, bool rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bool lhs, bquat rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bool lhs, bool rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Not (!v).
        /// </summary>
        public static bvec4 Not(bquat v) => new bvec4(!v.x, !v.y, !v.z, !v.w);
        
        /// <summary>
        /// Returns a bvec from the application of Not (!v).
        /// </summary>
        public static bvec4 Not(bool v) => new bvec4(!v);
        
        /// <summary>
        /// Returns a bquat from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bquat And(bquat lhs, bquat rhs) => new bquat(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z, lhs.w && rhs.w);
        
        /// <summary>
        /// Returns a bquat from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bquat And(bquat lhs, bool rhs) => new bquat(lhs.x && rhs, lhs.y && rhs, lhs.z && rhs, lhs.w && rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bquat And(bool lhs, bquat rhs) => new bquat(lhs && rhs.x, lhs && rhs.y, lhs && rhs.z, lhs && rhs.w);
        
        /// <summary>
        /// Returns a bquat from the application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bquat And(bool lhs, bool rhs) => new bquat(lhs && rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bquat Nand(bquat lhs, bquat rhs) => new bquat(!(lhs.x && rhs.x), !(lhs.y && rhs.y), !(lhs.z && rhs.z), !(lhs.w && rhs.w));
        
        /// <summary>
        /// Returns a bquat from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bquat Nand(bquat lhs, bool rhs) => new bquat(!(lhs.x && rhs), !(lhs.y && rhs), !(lhs.z && rhs), !(lhs.w && rhs));
        
        /// <summary>
        /// Returns a bquat from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bquat Nand(bool lhs, bquat rhs) => new bquat(!(lhs && rhs.x), !(lhs && rhs.y), !(lhs && rhs.z), !(lhs && rhs.w));
        
        /// <summary>
        /// Returns a bquat from the application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bquat Nand(bool lhs, bool rhs) => new bquat(!(lhs && rhs));
        
        /// <summary>
        /// Returns a bquat from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bquat Or(bquat lhs, bquat rhs) => new bquat(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z, lhs.w || rhs.w);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bquat Or(bquat lhs, bool rhs) => new bquat(lhs.x || rhs, lhs.y || rhs, lhs.z || rhs, lhs.w || rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bquat Or(bool lhs, bquat rhs) => new bquat(lhs || rhs.x, lhs || rhs.y, lhs || rhs.z, lhs || rhs.w);
        
        /// <summary>
        /// Returns a bquat from the application of Or (lhs || rhs).
        /// </summary>
        public static bquat Or(bool lhs, bool rhs) => new bquat(lhs || rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bquat Nor(bquat lhs, bquat rhs) => new bquat(!(lhs.x || rhs.x), !(lhs.y || rhs.y), !(lhs.z || rhs.z), !(lhs.w || rhs.w));
        
        /// <summary>
        /// Returns a bquat from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bquat Nor(bquat lhs, bool rhs) => new bquat(!(lhs.x || rhs), !(lhs.y || rhs), !(lhs.z || rhs), !(lhs.w || rhs));
        
        /// <summary>
        /// Returns a bquat from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bquat Nor(bool lhs, bquat rhs) => new bquat(!(lhs || rhs.x), !(lhs || rhs.y), !(lhs || rhs.z), !(lhs || rhs.w));
        
        /// <summary>
        /// Returns a bquat from the application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bquat Nor(bool lhs, bool rhs) => new bquat(!(lhs || rhs));
        
        /// <summary>
        /// Returns a bquat from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bquat Xor(bquat lhs, bquat rhs) => new bquat(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bquat Xor(bquat lhs, bool rhs) => new bquat(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bquat Xor(bool lhs, bquat rhs) => new bquat(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bquat from the application of Xor (lhs != rhs).
        /// </summary>
        public static bquat Xor(bool lhs, bool rhs) => new bquat(lhs != rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bquat Xnor(bquat lhs, bquat rhs) => new bquat(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bquat Xnor(bquat lhs, bool rhs) => new bquat(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bquat Xnor(bool lhs, bquat rhs) => new bquat(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bquat from the application of Xnor (lhs == rhs).
        /// </summary>
        public static bquat Xnor(bool lhs, bool rhs) => new bquat(lhs == rhs);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bquat from component-wise application of operator! (!v).
        /// </summary>
        public static bquat operator!(bquat v) => new bquat(!v.x, !v.y, !v.z, !v.w);
        
        /// <summary>
        /// Returns a bquat from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bquat operator&(bquat lhs, bquat rhs) => new bquat(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z, lhs.w && rhs.w);
        
        /// <summary>
        /// Returns a bquat from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bquat operator&(bquat lhs, bool rhs) => new bquat(lhs.x && rhs, lhs.y && rhs, lhs.z && rhs, lhs.w && rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bquat operator&(bool lhs, bquat rhs) => new bquat(lhs && rhs.x, lhs && rhs.y, lhs && rhs.z, lhs && rhs.w);
        
        /// <summary>
        /// Returns a bquat from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bquat operator|(bquat lhs, bquat rhs) => new bquat(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z, lhs.w || rhs.w);
        
        /// <summary>
        /// Returns a bquat from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bquat operator|(bquat lhs, bool rhs) => new bquat(lhs.x || rhs, lhs.y || rhs, lhs.z || rhs, lhs.w || rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bquat operator|(bool lhs, bquat rhs) => new bquat(lhs || rhs.x, lhs || rhs.y, lhs || rhs.z, lhs || rhs.w);

        #endregion

    }
}
