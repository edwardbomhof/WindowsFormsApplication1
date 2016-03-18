// Part of the controllsystem for a ABB-mounted 3D-printing head
// Made for the Bachelor’s thesis on Chalmers Tekniska Högskola
//
// Made by: Tomas Nilsson
// Robin Lindholm
// Markus Hägerstrand
//
// Date: 2013-05-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RobPro2
{
    /// <summary>
    /// Gets and sets values needed for a print.
    /// </summary>
    class GetSetVariables
    {
        double _x, _y, _z, _e, _f;
        /// <summary>
        /// Get/Set value
        /// X coordinate
        /// </summary>
        public double varX
        {
            get
            { return this._x; }
            set
            { this._x = value; }
        }
        /// <summary>
        /// Get/Set value
        /// Y coordinate
        /// </summary>
        public double varY
        {
            get
            { return this._y; }
            set
            { this._y = value; }
        }
        /// <summary>
/// Get/Set value
/// Z coordinate
/// </summary>
public double varZ
        {
            get
            { return this._z; }
            set
            { this._z = value; }
        }
        /// <summary>
        /// Get/Set value
        /// E variable coordinate
        /// </summary>
        public double varE
        {
            get
            { return this._e; }
            set
            { this._e = value; }
        }
        /// <summary>
        /// Get/Set value
        /// F variable
        /// </summary>
        public double varF
        {
            get
            { return this._f; }
            set
            { this._f = value; }
        }
    }
}