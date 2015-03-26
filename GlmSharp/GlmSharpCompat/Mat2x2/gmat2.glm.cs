using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
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
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public static T[,] Values<T>(gmat2<T> m) => m.Values;
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public static T[] Values1D<T>(gmat2<T> m) => m.Values1D;
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public static gvec2<T> Column0<T>(gmat2<T> m) => m.Column0;
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public static gvec2<T> Column1<T>(gmat2<T> m) => m.Column1;
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public static gvec2<T> Row0<T>(gmat2<T> m) => m.Row0;
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public static gvec2<T> Row1<T>(gmat2<T> m) => m.Row1;
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public static IEnumerator<T> GetEnumerator<T>(gmat2<T> m) => m.GetEnumerator();

    }
}
