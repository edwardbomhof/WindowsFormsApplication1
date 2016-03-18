using System.Windows.Forms;

namespace RobPro2
{
    partial class RobotPrototyping
    {
        //public Label lbl_InputFileLoaded;
        //public Label lbl_FileConverted;
        //public Label lbl_OutputFileLoaded;
        //public Label lbl_NumOfRows;
        //private TextBox txtB_NumOfLines;
        //private TextBox txtB_Z;
        //private TextBox txtB_X;
        //private TextBox txtB_Y;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_InputFileLoaded = new System.Windows.Forms.Label();
            this.lbl_OutputFileLoaded = new System.Windows.Forms.Label();
            this.lbl_FileConverted = new System.Windows.Forms.Label();
            this.lbl_NumOfRows = new System.Windows.Forms.Label();
            this.txtB_X = new System.Windows.Forms.TextBox();
            this.txtB_Y = new System.Windows.Forms.TextBox();
            this.txtB_Z = new System.Windows.Forms.TextBox();
            this.txtB_NumOfLines = new System.Windows.Forms.TextBox();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.btn_Output_File = new System.Windows.Forms.Button();
            this.btn_Convert_Code = new System.Windows.Forms.Button();
            this.btn_generate_code = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_InputFileLoaded
            // 
            this.lbl_InputFileLoaded.AutoSize = true;
            this.lbl_InputFileLoaded.Location = new System.Drawing.Point(13, 34);
            this.lbl_InputFileLoaded.Name = "lbl_InputFileLoaded";
            this.lbl_InputFileLoaded.Size = new System.Drawing.Size(31, 13);
            this.lbl_InputFileLoaded.TabIndex = 0;
            this.lbl_InputFileLoaded.Text = "Input";
            // 
            // lbl_OutputFileLoaded
            // 
            this.lbl_OutputFileLoaded.AutoSize = true;
            this.lbl_OutputFileLoaded.Location = new System.Drawing.Point(13, 51);
            this.lbl_OutputFileLoaded.Name = "lbl_OutputFileLoaded";
            this.lbl_OutputFileLoaded.Size = new System.Drawing.Size(39, 13);
            this.lbl_OutputFileLoaded.TabIndex = 1;
            this.lbl_OutputFileLoaded.Text = "Output";
            // 
            // lbl_FileConverted
            // 
            this.lbl_FileConverted.AutoSize = true;
            this.lbl_FileConverted.Location = new System.Drawing.Point(13, 64);
            this.lbl_FileConverted.Name = "lbl_FileConverted";
            this.lbl_FileConverted.Size = new System.Drawing.Size(56, 13);
            this.lbl_FileConverted.TabIndex = 2;
            this.lbl_FileConverted.Text = "Converted";
            // 
            // lbl_NumOfRows
            // 
            this.lbl_NumOfRows.AutoSize = true;
            this.lbl_NumOfRows.Location = new System.Drawing.Point(17, 96);
            this.lbl_NumOfRows.Name = "lbl_NumOfRows";
            this.lbl_NumOfRows.Size = new System.Drawing.Size(34, 13);
            this.lbl_NumOfRows.TabIndex = 3;
            this.lbl_NumOfRows.Text = "Rows";
            // 
            // txtB_X
            // 
            this.txtB_X.Location = new System.Drawing.Point(172, 152);
            this.txtB_X.Name = "txtB_X";
            this.txtB_X.Size = new System.Drawing.Size(100, 20);
            this.txtB_X.TabIndex = 4;
            this.txtB_X.Text = "X";
            // 
            // txtB_Y
            // 
            this.txtB_Y.Location = new System.Drawing.Point(172, 190);
            this.txtB_Y.Name = "txtB_Y";
            this.txtB_Y.Size = new System.Drawing.Size(100, 20);
            this.txtB_Y.TabIndex = 5;
            this.txtB_Y.Text = "Y";
            // 
            // txtB_Z
            // 
            this.txtB_Z.Location = new System.Drawing.Point(172, 217);
            this.txtB_Z.Name = "txtB_Z";
            this.txtB_Z.Size = new System.Drawing.Size(100, 20);
            this.txtB_Z.TabIndex = 6;
            this.txtB_Z.Text = "Z";
            // 
            // txtB_NumOfLines
            // 
            this.txtB_NumOfLines.Location = new System.Drawing.Point(172, 126);
            this.txtB_NumOfLines.Name = "txtB_NumOfLines";
            this.txtB_NumOfLines.Size = new System.Drawing.Size(100, 20);
            this.txtB_NumOfLines.TabIndex = 7;
            this.txtB_NumOfLines.Text = "NumOfLines";
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Location = new System.Drawing.Point(20, 126);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadFile.TabIndex = 8;
            this.btn_LoadFile.Text = "LoadFile";
            this.btn_LoadFile.UseVisualStyleBackColor = true;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // btn_Output_File
            // 
            this.btn_Output_File.Location = new System.Drawing.Point(20, 156);
            this.btn_Output_File.Name = "btn_Output_File";
            this.btn_Output_File.Size = new System.Drawing.Size(75, 23);
            this.btn_Output_File.TabIndex = 9;
            this.btn_Output_File.Text = "OutputFile";
            this.btn_Output_File.UseVisualStyleBackColor = true;
            this.btn_Output_File.Click += new System.EventHandler(this.btn_OutputFile_Click);
            // 
            // btn_Convert_Code
            // 
            this.btn_Convert_Code.Location = new System.Drawing.Point(20, 186);
            this.btn_Convert_Code.Name = "btn_Convert_Code";
            this.btn_Convert_Code.Size = new System.Drawing.Size(86, 23);
            this.btn_Convert_Code.TabIndex = 10;
            this.btn_Convert_Code.Text = "Convert code";
            this.btn_Convert_Code.UseVisualStyleBackColor = true;
            this.btn_Convert_Code.Click += new System.EventHandler(this.btn_ConvertCode_Click);
            // 
            // btn_generate_code
            // 
            this.btn_generate_code.Location = new System.Drawing.Point(20, 216);
            this.btn_generate_code.Name = "btn_generate_code";
            this.btn_generate_code.Size = new System.Drawing.Size(75, 23);
            this.btn_generate_code.TabIndex = 11;
            this.btn_generate_code.Text = "generate code";
            this.btn_generate_code.UseVisualStyleBackColor = true;
            this.btn_generate_code.Click += new System.EventHandler(this.btn_GenerateCode_Click);
            // 
            // RobotPrototyping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_generate_code);
            this.Controls.Add(this.btn_Convert_Code);
            this.Controls.Add(this.btn_Output_File);
            this.Controls.Add(this.btn_LoadFile);
            this.Controls.Add(this.txtB_NumOfLines);
            this.Controls.Add(this.txtB_Z);
            this.Controls.Add(this.txtB_Y);
            this.Controls.Add(this.txtB_X);
            this.Controls.Add(this.lbl_NumOfRows);
            this.Controls.Add(this.lbl_FileConverted);
            this.Controls.Add(this.lbl_OutputFileLoaded);
            this.Controls.Add(this.lbl_InputFileLoaded);
            this.Name = "RobotPrototyping";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btn_LoadFile_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_InputFileLoaded;
        private Label lbl_OutputFileLoaded;
        private Label lbl_FileConverted;
        private Label lbl_NumOfRows;
        private TextBox txtB_X;
        private TextBox txtB_Y;
        private TextBox txtB_Z;
        private TextBox txtB_NumOfLines;
        private Button btn_LoadFile;
        private Button btn_Output_File;
        private Button btn_Convert_Code;
        private Button btn_generate_code;
    }
}

