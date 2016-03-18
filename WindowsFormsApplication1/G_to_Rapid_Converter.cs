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
using System.IO;
using System.Globalization;
namespace RobPro2
{
    class G_to_Rapid_Converter
    {
        /// <summary>
        /// Converts GCode (from a .txt file) to pure coordinates and high/low signal depending on the stepstruder should feed or not
    /// </summary>
/// <param name="inputFileName">Input filename</param>
/// <param name="outputFileName">Output filename</param>
public static void GCodeToRapidConverter(string inputFileName,
string outputFileName, double[] XYZ)
        {
            // Load output file
            StreamWriter sw = new FileInfo(outputFileName).AppendText();
            // Load input file
            StreamReader sr = new StreamReader(inputFileName);
            GetSetVariables variablesXYZEF = new GetSetVariables();
            Dictionary<string, double> result = new Dictionary<string, double>();
            int numLines = 0;
            // Read every line
            while (sr.Peek() >= 0)
            {
                numLines++;
                bool posChanged = false, feedForward = false;
                // double posOffsetX = 100, posOffsetY = 50, posOffsetZ = 0.9;
                // Change the position of the print
                double posOffsetX = XYZ[0], posOffsetY = XYZ[1], posOffsetZ = XYZ[2];
                double varEOld = 0;
                string input = sr.ReadLine();
                // Find and remove commented code (;)
                int index = input.IndexOf(";");
                if (index >= 0)
            input = input.Substring(0, index);
                // Find G1 (coordinate information) and extract information and save it to X,Y,Z
            if (input != "" && input.Substring(0, 2) == "G1")
                {
                    input = input.Trim();
                    string[] pairs = input.Split();
                    // Go through the string pairs and find key values, if a pos. has changed, write a new one.
            foreach (string pair in pairs)
                    {
                        result.Add(pair.Substring(0, 1), double.Parse(pair.Substring(1),
                        CultureInfo.InvariantCulture));
                    }
                    if (result.ContainsKey("X"))
                    {
                        variablesXYZEF.varX = result["X"];
                        posChanged = true;
                    }
                    if (result.ContainsKey("Y"))
                    {
                        variablesXYZEF.varY = result["Y"];
                        posChanged = true;
                    }
                    if (result.ContainsKey("Z"))
                    {
                        variablesXYZEF.varZ = result["Z"];
                        posChanged = true;
                    }
                    if (result.ContainsKey("E"))
                    {
                        variablesXYZEF.varE = result["E"];
                        if (variablesXYZEF.varE > varEOld)
                            feedForward = true;
                        else
                            feedForward = false;
                        varEOld = variablesXYZEF.varE;
                    }
                    if (result.ContainsKey("F"))
                    {
                        variablesXYZEF.varF = result["F"];
                    }
                    result.Clear();
                    CultureInfo customCulture = (System.Globalization.CultureInfo)
                    System.Threading.Thread.CurrentThread.
                    CurrentCulture.Clone();
                    customCulture.NumberFormat.NumberDecimalSeparator = ".";
                    System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
                    // Just update the lines if a position has changed, and depending if the feedvalue is high or low
            if (posChanged && feedForward)
                        sw.WriteLine("1;[" + (variablesXYZEF.varX + posOffsetX) +
                        "," + (variablesXYZEF.varY + posOffsetY) + "," +
                        (variablesXYZEF.varZ + posOffsetZ) + "]");
                    if (posChanged && !feedForward)
                        sw.WriteLine("0;[" + (variablesXYZEF.varX + posOffsetX) +
                        "," + (variablesXYZEF.varY + posOffsetY) + "," +
                        (variablesXYZEF.varZ + posOffsetZ) + "]");
                    posChanged = false;
                }
            }
            sw.Flush();
            sw.Close();
            sr.Close();
        }
        /// <summary>
        /// Generates Rapid Code targets and movecommands in the shape of a rectangle in a textfile.
/// Starting coordinate is 0,0,0 (X, Y, Z)
///
/// Only used for testing, when for example you don’t have a
    /// </summary>
/// <param name="outputFileName">The file to write too</param>
/// <param name="numOfLines">Number of lines to generate</param>
public static void GenerateRapid(string outputFileName, int numOfLines)
        {
            StreamWriter sw = new FileInfo(outputFileName).AppendText();
            const int length = 100, width = 100, speed = 100;
            double X = 0, Y = 0, Z = 0;
            for (int i = 0; i < numOfLines; i++)
            {
                sw.WriteLine("[" + X + "," + Y + "," + Z + "]");
                if (Y == length)
                    Y = 0;
                else
                    Y = length;
                if (i % 2 != 0 && i != 0)
                    X = X + 1;
                if (X == width)
                {
                    Z = Z + 1;
                    X = 0;
}
            }
            for (int i = 0; i < numOfLines; i++)
            {
             sw.WriteLine("\tMoveL target_" + i + ",v"
            +speed + ",fine,Pen_TCP\\WObj:=Bord;");
            }
            sw.Flush();
            sw.Close();
        }
    }
}