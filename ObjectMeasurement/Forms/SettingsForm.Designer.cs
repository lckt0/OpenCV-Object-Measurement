namespace ObjectMeasurement
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.settings_visualSource = new System.Windows.Forms.ComboBox();
            this.settings_WebcamIndex = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.settings_ImageFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.settings_GeneralScale = new System.Windows.Forms.NumericUpDown();
            this.settings_DashGapScale = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.settings_Resolution = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.settings_WindowTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settings_WebcamIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_GeneralScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_DashGapScale)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visual Source";
            // 
            // settings_visualSource
            // 
            this.settings_visualSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settings_visualSource.FormattingEnabled = true;
            this.settings_visualSource.Items.AddRange(new object[] {
            "Web Camera",
            "Local File"});
            this.settings_visualSource.Location = new System.Drawing.Point(30, 103);
            this.settings_visualSource.Name = "settings_visualSource";
            this.settings_visualSource.Size = new System.Drawing.Size(130, 21);
            this.settings_visualSource.TabIndex = 1;
            // 
            // settings_WebcamIndex
            // 
            this.settings_WebcamIndex.Location = new System.Drawing.Point(30, 156);
            this.settings_WebcamIndex.Name = "settings_WebcamIndex";
            this.settings_WebcamIndex.Size = new System.Drawing.Size(130, 20);
            this.settings_WebcamIndex.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Webcam Index";
            // 
            // settings_ImageFile
            // 
            this.settings_ImageFile.Location = new System.Drawing.Point(30, 208);
            this.settings_ImageFile.Name = "settings_ImageFile";
            this.settings_ImageFile.Size = new System.Drawing.Size(130, 20);
            this.settings_ImageFile.TabIndex = 4;
            this.settings_ImageFile.Text = "./2.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "General Scale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Image File";
            // 
            // settings_GeneralScale
            // 
            this.settings_GeneralScale.Location = new System.Drawing.Point(235, 103);
            this.settings_GeneralScale.Name = "settings_GeneralScale";
            this.settings_GeneralScale.Size = new System.Drawing.Size(130, 20);
            this.settings_GeneralScale.TabIndex = 7;
            this.settings_GeneralScale.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // settings_DashGapScale
            // 
            this.settings_DashGapScale.Location = new System.Drawing.Point(235, 156);
            this.settings_DashGapScale.Name = "settings_DashGapScale";
            this.settings_DashGapScale.Size = new System.Drawing.Size(130, 20);
            this.settings_DashGapScale.TabIndex = 9;
            this.settings_DashGapScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dash Gap Scale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Resolution";
            // 
            // settings_Resolution
            // 
            this.settings_Resolution.Location = new System.Drawing.Point(235, 208);
            this.settings_Resolution.Name = "settings_Resolution";
            this.settings_Resolution.Size = new System.Drawing.Size(130, 20);
            this.settings_Resolution.TabIndex = 10;
            this.settings_Resolution.Text = "1920x1080";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "OpenCV Window Title";
            // 
            // settings_WindowTitle
            // 
            this.settings_WindowTitle.Location = new System.Drawing.Point(30, 51);
            this.settings_WindowTitle.Name = "settings_WindowTitle";
            this.settings_WindowTitle.Size = new System.Drawing.Size(335, 20);
            this.settings_WindowTitle.TabIndex = 12;
            this.settings_WindowTitle.Text = "Output Window";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.settings_WindowTitle);
            this.groupBox1.Controls.Add(this.settings_visualSource);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.settings_WebcamIndex);
            this.groupBox1.Controls.Add(this.settings_Resolution);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.settings_DashGapScale);
            this.groupBox1.Controls.Add(this.settings_ImageFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.settings_GeneralScale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 251);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OpenCV Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 275);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settings_WebcamIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_GeneralScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_DashGapScale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox settings_visualSource;
        private System.Windows.Forms.NumericUpDown settings_WebcamIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox settings_ImageFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown settings_GeneralScale;
        private System.Windows.Forms.NumericUpDown settings_DashGapScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox settings_Resolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox settings_WindowTitle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}