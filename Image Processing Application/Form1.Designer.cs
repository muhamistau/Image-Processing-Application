namespace Image_Processing_Application
{
    partial class Form1
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
            this.pictureBoxBefore = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAfter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brightnessButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.invertButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gBtButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gLumaButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gHumanEyeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gLevelingButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ThresholdButton = new System.Windows.Forms.Button();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hEqualizeButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.stretchContrastButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBefore
            // 
            this.pictureBoxBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBefore.Location = new System.Drawing.Point(12, 51);
            this.pictureBoxBefore.Name = "pictureBoxBefore";
            this.pictureBoxBefore.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBefore.TabIndex = 0;
            this.pictureBoxBefore.TabStop = false;
            this.pictureBoxBefore.Click += new System.EventHandler(this.pictureBoxBefore_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openImageToolStripMenuItem.Text = "Open Image...";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // pictureBoxAfter
            // 
            this.pictureBoxAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAfter.Location = new System.Drawing.Point(218, 51);
            this.pictureBoxAfter.Name = "pictureBoxAfter";
            this.pictureBoxAfter.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxAfter.TabIndex = 2;
            this.pictureBoxAfter.TabStop = false;
            this.pictureBoxAfter.Click += new System.EventHandler(this.pictureBoxAfter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Before:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "After:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brightnessButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxBrightness);
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brightness Control";
            // 
            // brightnessButton
            // 
            this.brightnessButton.Location = new System.Drawing.Point(119, 43);
            this.brightnessButton.Name = "brightnessButton";
            this.brightnessButton.Size = new System.Drawing.Size(75, 23);
            this.brightnessButton.TabIndex = 2;
            this.brightnessButton.Text = "Process";
            this.brightnessButton.UseVisualStyleBackColor = true;
            this.brightnessButton.Click += new System.EventHandler(this.brightnessButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Brightness Value";
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Location = new System.Drawing.Point(9, 45);
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrightness.TabIndex = 0;
            // 
            // invertButton
            // 
            this.invertButton.Location = new System.Drawing.Point(119, 39);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(75, 23);
            this.invertButton.TabIndex = 4;
            this.invertButton.Text = "Process";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Invert Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.invertButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Invertion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gBtButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.gLumaButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.gHumanEyeButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.gLevelingButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(218, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 181);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grayscale";
            // 
            // gBtButton
            // 
            this.gBtButton.Location = new System.Drawing.Point(119, 129);
            this.gBtButton.Name = "gBtButton";
            this.gBtButton.Size = new System.Drawing.Size(75, 23);
            this.gBtButton.TabIndex = 9;
            this.gBtButton.Text = "Process";
            this.gBtButton.UseVisualStyleBackColor = true;
            this.gBtButton.Click += new System.EventHandler(this.gBtButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "BT.601";
            // 
            // gLumaButton
            // 
            this.gLumaButton.Location = new System.Drawing.Point(119, 100);
            this.gLumaButton.Name = "gLumaButton";
            this.gLumaButton.Size = new System.Drawing.Size(75, 23);
            this.gLumaButton.TabIndex = 7;
            this.gLumaButton.Text = "Process";
            this.gLumaButton.UseVisualStyleBackColor = true;
            this.gLumaButton.Click += new System.EventHandler(this.gLumaButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Luma/ITU-R";
            // 
            // gHumanEyeButton
            // 
            this.gHumanEyeButton.Location = new System.Drawing.Point(119, 71);
            this.gHumanEyeButton.Name = "gHumanEyeButton";
            this.gHumanEyeButton.Size = new System.Drawing.Size(75, 23);
            this.gHumanEyeButton.TabIndex = 5;
            this.gHumanEyeButton.Text = "Process";
            this.gHumanEyeButton.UseVisualStyleBackColor = true;
            this.gHumanEyeButton.Click += new System.EventHandler(this.gHumanEyeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Human Eye Correction";
            // 
            // gLevelingButton
            // 
            this.gLevelingButton.Location = new System.Drawing.Point(119, 42);
            this.gLevelingButton.Name = "gLevelingButton";
            this.gLevelingButton.Size = new System.Drawing.Size(75, 23);
            this.gLevelingButton.TabIndex = 3;
            this.gLevelingButton.Text = "Process";
            this.gLevelingButton.UseVisualStyleBackColor = true;
            this.gLevelingButton.Click += new System.EventHandler(this.gLevelingButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Leveling Method";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ThresholdButton);
            this.groupBox4.Controls.Add(this.textBoxThreshold);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(426, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 181);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thresholding";
            // 
            // ThresholdButton
            // 
            this.ThresholdButton.Location = new System.Drawing.Point(119, 43);
            this.ThresholdButton.Name = "ThresholdButton";
            this.ThresholdButton.Size = new System.Drawing.Size(75, 23);
            this.ThresholdButton.TabIndex = 4;
            this.ThresholdButton.Text = "Process";
            this.ThresholdButton.UseVisualStyleBackColor = true;
            this.ThresholdButton.Click += new System.EventHandler(this.ThresholdButton_Click);
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(9, 45);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(100, 20);
            this.textBoxThreshold.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Threshold Value (T)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.hEqualizeButton);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(632, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 89);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Histogram Equalization";
            // 
            // hEqualizeButton
            // 
            this.hEqualizeButton.Location = new System.Drawing.Point(119, 39);
            this.hEqualizeButton.Name = "hEqualizeButton";
            this.hEqualizeButton.Size = new System.Drawing.Size(75, 23);
            this.hEqualizeButton.TabIndex = 4;
            this.hEqualizeButton.Text = "Process";
            this.hEqualizeButton.UseVisualStyleBackColor = true;
            this.hEqualizeButton.Click += new System.EventHandler(this.hEqualizeButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Equalize";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.stretchContrastButton);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(632, 349);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 89);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Contrast Stretching - Not woking";
            // 
            // stretchContrastButton
            // 
            this.stretchContrastButton.Enabled = false;
            this.stretchContrastButton.Location = new System.Drawing.Point(119, 39);
            this.stretchContrastButton.Name = "stretchContrastButton";
            this.stretchContrastButton.Size = new System.Drawing.Size(75, 23);
            this.stretchContrastButton.TabIndex = 4;
            this.stretchContrastButton.Text = "Process";
            this.stretchContrastButton.UseVisualStyleBackColor = true;
            this.stretchContrastButton.Click += new System.EventHandler(this.stretchContrastButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Stretch";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(519, 51);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(313, 99);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Histogram Before";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(519, 156);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(313, 99);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Histogram After";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.textBoxY);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.textBoxX);
            this.groupBox9.Location = new System.Drawing.Point(426, 51);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(87, 200);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Coordinate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "X";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(33, 79);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(48, 20);
            this.textBoxX.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Y";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(33, 117);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(48, 20);
            this.textBoxY.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAfter);
            this.Controls.Add(this.pictureBoxBefore);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing Application (140810160062)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBefore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBrightness;
        private System.Windows.Forms.Button brightnessButton;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button gLevelingButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button gBtButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button gLumaButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button gHumanEyeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ThresholdButton;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button hEqualizeButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button stretchContrastButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxY;
    }
}

