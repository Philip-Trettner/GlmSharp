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
        public static swizzle_gvec2<T> swizzle<T>(gvec2<T> v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static T[] Values<T>(gvec2<T> v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<T> GetEnumerator<T>(gvec2<T> v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString<T>(gvec2<T> v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString<T>(gvec2<T> v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count<T>(gvec2<T> v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals<T>(gvec2<T> v, gvec2<T> rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals<T>(gvec2<T> v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode<T>(gvec2<T> v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec2 Equal<T>(gvec2<T> lhs, gvec2<T> rhs) => gvec2<T>.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec2 NotEqual<T>(gvec2<T> lhs, gvec2<T> rhs) => gvec2<T>.NotEqual(lhs, rhs);

    }
}
