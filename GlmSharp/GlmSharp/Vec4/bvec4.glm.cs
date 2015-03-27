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
        public static swizzle_bvec4 swizzle(bvec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static bool[] Values(bvec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<bool> GetEnumerator(bvec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(bvec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(bvec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(bvec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(bvec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(bvec4 v, bvec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(bvec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(bvec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bvec4 lhs, bvec4 rhs) => bvec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bvec4 lhs, bvec4 rhs) => bvec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Not (!v).
        /// </summary>
        public static bvec4 Not(bvec4 v) => bvec4.Not(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bvec4 And(bvec4 lhs, bvec4 rhs) => bvec4.And(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bvec4 Nand(bvec4 lhs, bvec4 rhs) => bvec4.Nand(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bvec4 Or(bvec4 lhs, bvec4 rhs) => bvec4.Or(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bvec4 Nor(bvec4 lhs, bvec4 rhs) => bvec4.Nor(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bvec4 Xor(bvec4 lhs, bvec4 rhs) => bvec4.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bvec4 Xnor(bvec4 lhs, bvec4 rhs) => bvec4.Xnor(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static bool MinElement(bvec4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static bool MaxElement(bvec4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public static bool All(bvec4 v) => v.All;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public static bool Any(bvec4 v) => v.Any;

    }
}
