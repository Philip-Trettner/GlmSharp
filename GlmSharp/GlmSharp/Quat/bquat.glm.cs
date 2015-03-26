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
        /// Returns an array with all values
        /// </summary>
        public static bool[] Values(bquat q) => q.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<bool> GetEnumerator(bquat q) => q.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public static string ToString(bquat q) => q.ToString();
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public static string ToString(bquat q, string sep) => q.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(bquat q, string sep, IFormatProvider provider) => q.ToString(sep, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(bquat q) => q.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(bquat q, bquat rhs) => q.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(bquat q, object obj) => q.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(bquat q) => q.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(bquat lhs, bquat rhs) => bquat.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(bquat lhs, bquat rhs) => bquat.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Not (!v).
        /// </summary>
        public static bvec4 Not(bquat v) => bquat.Not(v);
        
        /// <summary>
        /// Returns a bquat from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bquat And(bquat lhs, bquat rhs) => bquat.And(lhs, rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bquat Nand(bquat lhs, bquat rhs) => bquat.Nand(lhs, rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bquat Or(bquat lhs, bquat rhs) => bquat.Or(lhs, rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bquat Nor(bquat lhs, bquat rhs) => bquat.Nor(lhs, rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bquat Xor(bquat lhs, bquat rhs) => bquat.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a bquat from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bquat Xnor(bquat lhs, bquat rhs) => bquat.Xnor(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this quaternion.
        /// </summary>
        public static bool MinElement(bquat q) => q.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this quaternion.
        /// </summary>
        public static bool MaxElement(bquat q) => q.MaxElement;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public static bool All(bquat q) => q.All;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public static bool Any(bquat q) => q.Any;

    }
}
