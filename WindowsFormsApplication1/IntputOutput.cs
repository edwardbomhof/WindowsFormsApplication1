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
using System.Windows.Forms;
using System.IO;
namespace RobPro2
{
    /// <summary>
    /// Handles input/output information
    /// </summary>
    class InputOutput
    {
        /// <summary>
        /// Starts a FileDialog and gets the filepath to the selected file.
        /// </summary>
        /// <returns>String containing the filepath.</returns>
        public static String LoadFilePath()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            else
            {
                return null;
            }
        }
        public static int NumberOfLines(string filePath)
        {
            return File.ReadLines(filePath).Count();
        }
    }
}