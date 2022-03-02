namespace ObjectMeasurement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pageConsole = new System.Windows.Forms.TabPage();
            this.pageHome = new System.Windows.Forms.TabPage();
            this.menuCtrl = new System.Windows.Forms.TabControl();
            this.configureBtn = new System.Windows.Forms.Button();
            this.closeCheck = new System.Windows.Forms.CheckBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.appConsole = new ConsoleControl.ConsoleControl();
            this.pageConsole.SuspendLayout();
            this.pageHome.SuspendLayout();
            this.menuCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageConsole
            // 
            this.pageConsole.Controls.Add(this.appConsole);
            this.pageConsole.Location = new System.Drawing.Point(4, 22);
            this.pageConsole.Name = "pageConsole";
            this.pageConsole.Padding = new System.Windows.Forms.Padding(3);
            this.pageConsole.Size = new System.Drawing.Size(599, 281);
            this.pageConsole.TabIndex = 1;
            this.pageConsole.Text = "Console";
            this.pageConsole.UseVisualStyleBackColor = true;
            // 
            // pageHome
            // 
            this.pageHome.BackColor = System.Drawing.SystemColors.Control;
            this.pageHome.Controls.Add(this.configureBtn);
            this.pageHome.Controls.Add(this.closeCheck);
            this.pageHome.Controls.Add(this.exitBtn);
            this.pageHome.Controls.Add(this.titleLbl);
            this.pageHome.Controls.Add(this.startBtn);
            this.pageHome.Location = new System.Drawing.Point(4, 22);
            this.pageHome.Name = "pageHome";
            this.pageHome.Padding = new System.Windows.Forms.Padding(3);
            this.pageHome.Size = new System.Drawing.Size(599, 281);
            this.pageHome.TabIndex = 0;
            this.pageHome.Text = "Home";
            // 
            // menuCtrl
            // 
            this.menuCtrl.Controls.Add(this.pageHome);
            this.menuCtrl.Controls.Add(this.pageConsole);
            this.menuCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuCtrl.Location = new System.Drawing.Point(0, 0);
            this.menuCtrl.Name = "menuCtrl";
            this.menuCtrl.SelectedIndex = 0;
            this.menuCtrl.Size = new System.Drawing.Size(607, 307);
            this.menuCtrl.TabIndex = 8;
            // 
            // configureBtn
            // 
            this.configureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configureBtn.Location = new System.Drawing.Point(155, 155);
            this.configureBtn.Name = "configureBtn";
            this.configureBtn.Size = new System.Drawing.Size(221, 40);
            this.configureBtn.TabIndex = 12;
            this.configureBtn.Text = "Configure Settings";
            this.configureBtn.UseVisualStyleBackColor = true;
            this.configureBtn.Click += new System.EventHandler(this.configureBtn_Click);
            // 
            // closeCheck
            // 
            this.closeCheck.Location = new System.Drawing.Point(8, 258);
            this.closeCheck.Name = "closeCheck";
            this.closeCheck.Size = new System.Drawing.Size(227, 17);
            this.closeCheck.TabIndex = 11;
            this.closeCheck.Text = "Hide  launcher window when core\r\n started";
            this.closeCheck.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Location = new System.Drawing.Point(382, 155);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(62, 40);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLbl.Location = new System.Drawing.Point(3, 3);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(593, 74);
            this.titleLbl.TabIndex = 9;
            this.titleLbl.Text = "OpenCV Object Measurement\r\nLauncher";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(155, 111);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(289, 38);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start with Python";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // appConsole
            // 
            this.appConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appConsole.IsInputEnabled = true;
            this.appConsole.Location = new System.Drawing.Point(3, 3);
            this.appConsole.Name = "appConsole";
            this.appConsole.SendKeyboardCommandsToProcess = false;
            this.appConsole.ShowDiagnostics = false;
            this.appConsole.Size = new System.Drawing.Size(593, 275);
            this.appConsole.TabIndex = 0;
            this.appConsole.Load += new System.EventHandler(this.appConsole_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 307);
            this.Controls.Add(this.menuCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OpenCV Object Measurement";
            this.pageConsole.ResumeLayout(false);
            this.pageHome.ResumeLayout(false);
            this.menuCtrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageConsole;
        private System.Windows.Forms.TabPage pageHome;
        private System.Windows.Forms.TabControl menuCtrl;
        private System.Windows.Forms.Button configureBtn;
        private System.Windows.Forms.CheckBox closeCheck;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button startBtn;
        private ConsoleControl.ConsoleControl appConsole;
    }
}

