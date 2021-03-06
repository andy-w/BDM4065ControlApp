﻿namespace BDM4065ControlApp
{
    public partial class Form1
    {
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
            this.InputSourceHDMIButton = new System.Windows.Forms.Button();
            this.InputSourceDPButton = new System.Windows.Forms.Button();
            this.CurrentSourceGroupBox = new System.Windows.Forms.GroupBox();
            this.InputSourceHDMI2Button = new System.Windows.Forms.Button();
            this.InputSourceDVIButton = new System.Windows.Forms.Button();
            this.InputSourcemDPButton = new System.Windows.Forms.Button();
            this.InputSourceVGAButton = new System.Windows.Forms.Button();
            this.VideoParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.SharpnessUpDown = new System.Windows.Forms.NumericUpDown();
            this.ContrastUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrightnessUpDown = new System.Windows.Forms.NumericUpDown();
            this.PictureFormatComboBox = new System.Windows.Forms.ComboBox();
            this.PowerStateGroupBox = new System.Windows.Forms.GroupBox();
            this.PowerStateOnButton = new System.Windows.Forms.Button();
            this.PowerStateOffButton = new System.Windows.Forms.Button();
            this.PictureFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.VolumeUpDown = new System.Windows.Forms.NumericUpDown();
            this.VolumeGroupBox = new System.Windows.Forms.GroupBox();
            this.VolumeResetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SerialNoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.CurrentSourceGroupBox.SuspendLayout();
            this.VideoParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SharpnessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessUpDown)).BeginInit();
            this.PowerStateGroupBox.SuspendLayout();
            this.PictureFormatGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeUpDown)).BeginInit();
            this.VolumeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputSourceHDMIButton
            // 
            this.InputSourceHDMIButton.Location = new System.Drawing.Point(6, 78);
            this.InputSourceHDMIButton.Name = "InputSourceHDMIButton";
            this.InputSourceHDMIButton.Size = new System.Drawing.Size(91, 26);
            this.InputSourceHDMIButton.TabIndex = 1;
            this.InputSourceHDMIButton.Text = "HDMI";
            this.InputSourceHDMIButton.UseVisualStyleBackColor = true;
            this.InputSourceHDMIButton.Click += new System.EventHandler(this.InputSourceHDMIButton_Click);
            // 
            // InputSourceDPButton
            // 
            this.InputSourceDPButton.Location = new System.Drawing.Point(6, 137);
            this.InputSourceDPButton.Name = "InputSourceDPButton";
            this.InputSourceDPButton.Size = new System.Drawing.Size(91, 25);
            this.InputSourceDPButton.TabIndex = 1;
            this.InputSourceDPButton.Text = "DP";
            this.InputSourceDPButton.UseVisualStyleBackColor = true;
            this.InputSourceDPButton.Click += new System.EventHandler(this.InputSourceDPButton_Click);
            // 
            // CurrentSourceGroupBox
            // 
            this.CurrentSourceGroupBox.Controls.Add(this.InputSourceHDMI2Button);
            this.CurrentSourceGroupBox.Controls.Add(this.InputSourceDVIButton);
            this.CurrentSourceGroupBox.Controls.Add(this.InputSourcemDPButton);
            this.CurrentSourceGroupBox.Controls.Add(this.InputSourceVGAButton);
            this.CurrentSourceGroupBox.Controls.Add(this.InputSourceHDMIButton);
            this.CurrentSourceGroupBox.Controls.Add(this.InputSourceDPButton);
            this.CurrentSourceGroupBox.Enabled = false;
            this.CurrentSourceGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CurrentSourceGroupBox.Name = "CurrentSourceGroupBox";
            this.CurrentSourceGroupBox.Size = new System.Drawing.Size(109, 205);
            this.CurrentSourceGroupBox.TabIndex = 2;
            this.CurrentSourceGroupBox.TabStop = false;
            this.CurrentSourceGroupBox.Text = "Current Source";
            // 
            // InputSourceHDMI2Button
            // 
            this.InputSourceHDMI2Button.Location = new System.Drawing.Point(6, 110);
            this.InputSourceHDMI2Button.Name = "InputSourceHDMI2Button";
            this.InputSourceHDMI2Button.Size = new System.Drawing.Size(91, 21);
            this.InputSourceHDMI2Button.TabIndex = 5;
            this.InputSourceHDMI2Button.Text = "HDMI 2";
            this.InputSourceHDMI2Button.UseVisualStyleBackColor = true;
            this.InputSourceHDMI2Button.Click += new System.EventHandler(this.InputSourceHDMI2Button_Click);
            // 
            // InputSourceDVIButton
            // 
            this.InputSourceDVIButton.Location = new System.Drawing.Point(6, 49);
            this.InputSourceDVIButton.Name = "InputSourceDVIButton";
            this.InputSourceDVIButton.Size = new System.Drawing.Size(91, 23);
            this.InputSourceDVIButton.TabIndex = 4;
            this.InputSourceDVIButton.Text = "DVI";
            this.InputSourceDVIButton.UseVisualStyleBackColor = true;
            this.InputSourceDVIButton.Click += new System.EventHandler(this.InputSourceDVIButton_Click);
            // 
            // InputSourcemDPButton
            // 
            this.InputSourcemDPButton.Location = new System.Drawing.Point(6, 168);
            this.InputSourcemDPButton.Name = "InputSourcemDPButton";
            this.InputSourcemDPButton.Size = new System.Drawing.Size(91, 29);
            this.InputSourcemDPButton.TabIndex = 3;
            this.InputSourcemDPButton.Text = "miniDP";
            this.InputSourcemDPButton.UseVisualStyleBackColor = true;
            this.InputSourcemDPButton.Click += new System.EventHandler(this.InputSourcemDPButton_Click);
            // 
            // InputSourceVGAButton
            // 
            this.InputSourceVGAButton.Location = new System.Drawing.Point(6, 20);
            this.InputSourceVGAButton.Name = "InputSourceVGAButton";
            this.InputSourceVGAButton.Size = new System.Drawing.Size(91, 23);
            this.InputSourceVGAButton.TabIndex = 2;
            this.InputSourceVGAButton.Text = "VGA";
            this.InputSourceVGAButton.UseVisualStyleBackColor = true;
            this.InputSourceVGAButton.Click += new System.EventHandler(this.InputSourceVGAButton_Click);
            // 
            // VideoParametersGroupBox
            // 
            this.VideoParametersGroupBox.Controls.Add(this.SharpnessUpDown);
            this.VideoParametersGroupBox.Controls.Add(this.ContrastUpDown);
            this.VideoParametersGroupBox.Controls.Add(this.label3);
            this.VideoParametersGroupBox.Controls.Add(this.label2);
            this.VideoParametersGroupBox.Controls.Add(this.label1);
            this.VideoParametersGroupBox.Controls.Add(this.BrightnessUpDown);
            this.VideoParametersGroupBox.Location = new System.Drawing.Point(127, 12);
            this.VideoParametersGroupBox.Name = "VideoParametersGroupBox";
            this.VideoParametersGroupBox.Size = new System.Drawing.Size(137, 104);
            this.VideoParametersGroupBox.TabIndex = 3;
            this.VideoParametersGroupBox.TabStop = false;
            this.VideoParametersGroupBox.Text = "Video Parameters";
            // 
            // SharpnessUpDown
            // 
            this.SharpnessUpDown.Location = new System.Drawing.Point(76, 72);
            this.SharpnessUpDown.Name = "SharpnessUpDown";
            this.SharpnessUpDown.Size = new System.Drawing.Size(50, 20);
            this.SharpnessUpDown.TabIndex = 5;
            // 
            // ContrastUpDown
            // 
            this.ContrastUpDown.Location = new System.Drawing.Point(76, 46);
            this.ContrastUpDown.Name = "ContrastUpDown";
            this.ContrastUpDown.Size = new System.Drawing.Size(50, 20);
            this.ContrastUpDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sharpness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brightness";
            // 
            // BrightnessUpDown
            // 
            this.BrightnessUpDown.Location = new System.Drawing.Point(76, 20);
            this.BrightnessUpDown.Name = "BrightnessUpDown";
            this.BrightnessUpDown.Size = new System.Drawing.Size(50, 20);
            this.BrightnessUpDown.TabIndex = 0;
            // 
            // PictureFormatComboBox
            // 
            this.PictureFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PictureFormatComboBox.FormattingEnabled = true;
            this.PictureFormatComboBox.Location = new System.Drawing.Point(6, 17);
            this.PictureFormatComboBox.Name = "PictureFormatComboBox";
            this.PictureFormatComboBox.Size = new System.Drawing.Size(104, 21);
            this.PictureFormatComboBox.TabIndex = 5;
            this.PictureFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.PictureFormatComboBox_SelectedIndexChanged);
            // 
            // PowerStateGroupBox
            // 
            this.PowerStateGroupBox.Controls.Add(this.PowerStateOnButton);
            this.PowerStateGroupBox.Controls.Add(this.PowerStateOffButton);
            this.PowerStateGroupBox.Location = new System.Drawing.Point(270, 12);
            this.PowerStateGroupBox.Name = "PowerStateGroupBox";
            this.PowerStateGroupBox.Size = new System.Drawing.Size(131, 52);
            this.PowerStateGroupBox.TabIndex = 6;
            this.PowerStateGroupBox.TabStop = false;
            this.PowerStateGroupBox.Text = "Power State";
            // 
            // PowerStateOnButton
            // 
            this.PowerStateOnButton.Location = new System.Drawing.Point(69, 19);
            this.PowerStateOnButton.Name = "PowerStateOnButton";
            this.PowerStateOnButton.Size = new System.Drawing.Size(56, 24);
            this.PowerStateOnButton.TabIndex = 1;
            this.PowerStateOnButton.Text = "On";
            this.PowerStateOnButton.UseVisualStyleBackColor = true;
            this.PowerStateOnButton.Click += new System.EventHandler(this.PowerStateOnButton_Click);
            // 
            // PowerStateOffButton
            // 
            this.PowerStateOffButton.Location = new System.Drawing.Point(6, 19);
            this.PowerStateOffButton.Name = "PowerStateOffButton";
            this.PowerStateOffButton.Size = new System.Drawing.Size(57, 24);
            this.PowerStateOffButton.TabIndex = 0;
            this.PowerStateOffButton.Text = "Off";
            this.PowerStateOffButton.UseVisualStyleBackColor = true;
            this.PowerStateOffButton.Click += new System.EventHandler(this.PowerStateOffButton_Click);
            // 
            // PictureFormatGroupBox
            // 
            this.PictureFormatGroupBox.Controls.Add(this.PictureFormatComboBox);
            this.PictureFormatGroupBox.Location = new System.Drawing.Point(127, 122);
            this.PictureFormatGroupBox.Name = "PictureFormatGroupBox";
            this.PictureFormatGroupBox.Size = new System.Drawing.Size(120, 43);
            this.PictureFormatGroupBox.TabIndex = 7;
            this.PictureFormatGroupBox.TabStop = false;
            this.PictureFormatGroupBox.Text = "Picture Format";
            // 
            // VolumeUpDown
            // 
            this.VolumeUpDown.Location = new System.Drawing.Point(81, 20);
            this.VolumeUpDown.Name = "VolumeUpDown";
            this.VolumeUpDown.Size = new System.Drawing.Size(50, 20);
            this.VolumeUpDown.TabIndex = 8;
            this.VolumeUpDown.ValueChanged += new System.EventHandler(this.VolumeUpDown_ValueChanged);
            // 
            // VolumeGroupBox
            // 
            this.VolumeGroupBox.Controls.Add(this.VolumeResetButton);
            this.VolumeGroupBox.Controls.Add(this.VolumeUpDown);
            this.VolumeGroupBox.Location = new System.Drawing.Point(127, 171);
            this.VolumeGroupBox.Name = "VolumeGroupBox";
            this.VolumeGroupBox.Size = new System.Drawing.Size(137, 46);
            this.VolumeGroupBox.TabIndex = 9;
            this.VolumeGroupBox.TabStop = false;
            this.VolumeGroupBox.Text = "Volume";
            // 
            // VolumeResetButton
            // 
            this.VolumeResetButton.Location = new System.Drawing.Point(6, 19);
            this.VolumeResetButton.Name = "VolumeResetButton";
            this.VolumeResetButton.Size = new System.Drawing.Size(50, 22);
            this.VolumeResetButton.TabIndex = 9;
            this.VolumeResetButton.Text = "Reset";
            this.VolumeResetButton.UseVisualStyleBackColor = true;
            this.VolumeResetButton.Click += new System.EventHandler(this.VolumeResetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Serial No";
            // 
            // SerialNoTextBox
            // 
            this.SerialNoTextBox.Location = new System.Drawing.Point(71, 236);
            this.SerialNoTextBox.Name = "SerialNoTextBox";
            this.SerialNoTextBox.ReadOnly = true;
            this.SerialNoTextBox.Size = new System.Drawing.Size(115, 20);
            this.SerialNoTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Temperature (C)";
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.Location = new System.Drawing.Point(357, 236);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.ReadOnly = true;
            this.TemperatureTextBox.Size = new System.Drawing.Size(44, 20);
            this.TemperatureTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 262);
            this.Controls.Add(this.TemperatureTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SerialNoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VolumeGroupBox);
            this.Controls.Add(this.PictureFormatGroupBox);
            this.Controls.Add(this.PowerStateGroupBox);
            this.Controls.Add(this.VideoParametersGroupBox);
            this.Controls.Add(this.CurrentSourceGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CurrentSourceGroupBox.ResumeLayout(false);
            this.VideoParametersGroupBox.ResumeLayout(false);
            this.VideoParametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SharpnessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessUpDown)).EndInit();
            this.PowerStateGroupBox.ResumeLayout(false);
            this.PictureFormatGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeUpDown)).EndInit();
            this.VolumeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InputSourceHDMIButton;
        private System.Windows.Forms.Button InputSourceDPButton;
        private System.Windows.Forms.GroupBox CurrentSourceGroupBox;
        private System.Windows.Forms.GroupBox VideoParametersGroupBox;
        private System.Windows.Forms.NumericUpDown SharpnessUpDown;
        private System.Windows.Forms.NumericUpDown ContrastUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BrightnessUpDown;
        private System.Windows.Forms.ComboBox PictureFormatComboBox;
        private System.Windows.Forms.Button InputSourcemDPButton;
        private System.Windows.Forms.Button InputSourceVGAButton;
        private System.Windows.Forms.Button InputSourceHDMI2Button;
        private System.Windows.Forms.Button InputSourceDVIButton;
        private System.Windows.Forms.GroupBox PowerStateGroupBox;
        private System.Windows.Forms.Button PowerStateOnButton;
        private System.Windows.Forms.Button PowerStateOffButton;
        private System.Windows.Forms.GroupBox PictureFormatGroupBox;
        private System.Windows.Forms.NumericUpDown VolumeUpDown;
        private System.Windows.Forms.GroupBox VolumeGroupBox;
        private System.Windows.Forms.Button VolumeResetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SerialNoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TemperatureTextBox;
    }
}