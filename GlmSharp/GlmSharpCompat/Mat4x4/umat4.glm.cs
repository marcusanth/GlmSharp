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
        public static uint[,] Values(umat4 m) => m.Values;
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public static uint[] Values1D(umat4 m) => m.Values1D;
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public static uvec4 Column0(umat4 m) => m.Column0;
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public static uvec4 Column1(umat4 m) => m.Column1;
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public static uvec4 Column2(umat4 m) => m.Column2;
        
        /// <summary>
        /// Returns the column nr 3
        /// </summary>
        public static uvec4 Column3(umat4 m) => m.Column3;
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public static uvec4 Row0(umat4 m) => m.Row0;
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public static uvec4 Row1(umat4 m) => m.Row1;
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public static uvec4 Row2(umat4 m) => m.Row2;
        
        /// <summary>
        /// Returns the row nr 3
        /// </summary>
        public static uvec4 Row3(umat4 m) => m.Row3;
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public static IEnumerator<uint> GetEnumerator(umat4 m) => m.GetEnumerator();

    }
}
