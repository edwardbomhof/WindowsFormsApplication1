// Part of the control system for a ABB-mounted 3D-printing head
// Made for the Bachelor’s thesis on Chalmers Tekniska Högskola
//
// Made by: Tomas Nilsson
// Robin Lindholm
// Markus Hägerstrand
//
// Date: 2013-05-22
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace RobPro2
{
    public partial class RobotPrototyping : Form
    {
        public RobotPrototyping()
        {
            InitializeComponent();
        }
        // Filenames for input/output files
        protected String inputFileName, outputFileName;
        /// <summary>
        /// Button clicked
        /// Method to specify the file to read G-Code from.
        /// It has to be in the ".txt" format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            String inputGCodeFilePath = InputOutput.LoadFilePath();
            if (inputGCodeFilePath != null &&
            Path.GetExtension(inputGCodeFilePath) == ".txt")
            {
                lbl_InputFileLoaded.Text = inputGCodeFilePath;
                inputFileName = inputGCodeFilePath;
            }
            else
            {
                MessageBox.Show("Error loading the G-Code, have you made sure it is in .txt format ? ");
            }
        }
        /// <summary>
        /// What to do when the form closes.
        /// Check for a close confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RobotPrototyping_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirm Close",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RobotPrototyping_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Button clicked
        /// Method to specify what file to write to.
        /// It has to be in the .txt format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OutputFile_Click(object sender, EventArgs e)
        {
            String outputGCodeFilePath = InputOutput.LoadFilePath();
            if (outputGCodeFilePath != null &&
            Path.GetExtension(outputGCodeFilePath) == ".txt")
            {
                lbl_OutputFileLoaded.Text = outputGCodeFilePath;
                outputFileName = outputGCodeFilePath;
            }
            else
            {
                MessageBox.Show("Error loading the outputfile, have you made sure it is in .txt format ? ");
            }
        }
        /// <summary>
        /// Button clicked
        /// Method that calls the convert function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConvertCode_Click(object sender, EventArgs e)
        {
            if (inputFileName != null && outputFileName != null)
            {
                double[] XYZ = { double.Parse(txtB_X.Text), double.Parse(txtB_Y.Text),
            double.Parse(txtB_Z.Text) };
                G_to_Rapid_Converter.GCodeToRapidConverter(inputFileName, outputFileName, XYZ);
                lbl_FileConverted.Text = "File Converted";
            }
            else
            {
                MessageBox.Show("Error: There is something wrong with the input / output files, have you specified them ? ");
            }
        }
        /// <summary>
        /// Button clicked
        /// Method that calls a class that generates a dummy code with coordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GenerateCode_Click(object sender, EventArgs e)
        {
            if (outputFileName == null)
            {
                outputFileName = "C:\\Users\\Tomas\\Dropbox\\Kandidat\\Program\\RobPro2\\RobPro2\\Resources\\OutputFile";
            }
            G_to_Rapid_Converter.GenerateRapid(outputFileName,
            int.Parse(txtB_NumOfLines.Text));
            lbl_NumOfRows.Text = InputOutput.NumberOfLines(outputFileName).ToString();
        }
    }
}