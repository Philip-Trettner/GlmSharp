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
    /// Static class that contains static glm functions
    /// </summary>
    public static partial class glm
    {
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public static swizzle_bvec3 swizzle(bvec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static bool[] Values(bvec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<bool> GetEnumerator(bvec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(bvec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(bvec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(bvec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(bvec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(bvec3 v, bvec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(bvec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(bvec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(bvec3 lhs, bvec3 rhs) => bvec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(bool lhs, bool rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(bvec3 lhs, bvec3 rhs) => bvec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(bool lhs, bool rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Not (!v).
        /// </summary>
        public static bvec3 Not(bvec3 v) => bvec3.Not(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Not (!v).
        /// </summary>
        public static bool Not(bool v) => !v;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec3 And(bvec3 lhs, bvec3 rhs) => bvec3.And(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bool And(bool lhs, bool rhs) => lhs && rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec3 Nand(bvec3 lhs, bvec3 rhs) => bvec3.Nand(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bool Nand(bool lhs, bool rhs) => !(lhs && rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec3 Or(bvec3 lhs, bvec3 rhs) => bvec3.Or(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bool Or(bool lhs, bool rhs) => lhs || rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec3 Nor(bvec3 lhs, bvec3 rhs) => bvec3.Nor(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bool Nor(bool lhs, bool rhs) => !(lhs || rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec3 Xor(bvec3 lhs, bvec3 rhs) => bvec3.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bool Xor(bool lhs, bool rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec3 Xnor(bvec3 lhs, bvec3 rhs) => bvec3.Xnor(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bool Xnor(bool lhs, bool rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static bool MinElement(bvec3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static bool MaxElement(bvec3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public static bool All(bvec3 v) => v.All;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public static bool Any(bvec3 v) => v.Any;

    }
}
