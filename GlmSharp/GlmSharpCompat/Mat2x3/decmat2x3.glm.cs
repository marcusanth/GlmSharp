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
        public static decimal[,] Values(decmat2x3 m) => m.Values;
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public static decimal[] Values1D(decmat2x3 m) => m.Values1D;
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public static decvec3 Column0(decmat2x3 m) => m.Column0;
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public static decvec3 Column1(decmat2x3 m) => m.Column1;
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public static decvec2 Row0(decmat2x3 m) => m.Row0;
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public static decvec2 Row1(decmat2x3 m) => m.Row1;
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public static decvec2 Row2(decmat2x3 m) => m.Row2;
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public static IEnumerator<decimal> GetEnumerator(decmat2x3 m) => m.GetEnumerator();

    }
}
