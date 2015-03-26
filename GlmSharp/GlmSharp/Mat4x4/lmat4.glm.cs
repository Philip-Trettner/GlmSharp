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
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public static long[,] Values(lmat4 m) => m.Values;
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public static long[] Values1D(lmat4 m) => m.Values1D;
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public static lvec4 Column0(lmat4 m) => m.Column0;
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public static lvec4 Column1(lmat4 m) => m.Column1;
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public static lvec4 Column2(lmat4 m) => m.Column2;
        
        /// <summary>
        /// Returns the column nr 3
        /// </summary>
        public static lvec4 Column3(lmat4 m) => m.Column3;
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public static lvec4 Row0(lmat4 m) => m.Row0;
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public static lvec4 Row1(lmat4 m) => m.Row1;
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public static lvec4 Row2(lmat4 m) => m.Row2;
        
        /// <summary>
        /// Returns the row nr 3
        /// </summary>
        public static lvec4 Row3(lmat4 m) => m.Row3;
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public static IEnumerator<long> GetEnumerator(lmat4 m) => m.GetEnumerator();

    }
}