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
        public static Half[,] Values(hmat4x2 m) => m.Values;
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public static Half[] Values1D(hmat4x2 m) => m.Values1D;
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public static hvec2 Column0(hmat4x2 m) => m.Column0;
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public static hvec2 Column1(hmat4x2 m) => m.Column1;
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public static hvec2 Column2(hmat4x2 m) => m.Column2;
        
        /// <summary>
        /// Returns the column nr 3
        /// </summary>
        public static hvec2 Column3(hmat4x2 m) => m.Column3;
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public static hvec4 Row0(hmat4x2 m) => m.Row0;
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public static hvec4 Row1(hmat4x2 m) => m.Row1;
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public static IEnumerator<Half> GetEnumerator(hmat4x2 m) => m.GetEnumerator();

    }
}
