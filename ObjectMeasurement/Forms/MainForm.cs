using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ObjectMeasurement
{
    public partial class MainForm : Form
    {
        string corePath;
        string corePathExe;
        public static CoreSettings coreSettings = new CoreSettings(@"./settings.json");

        public MainForm()
        {
            InitializeComponent();

            #region FormDesign
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            corePath = "./core.py";
            corePathExe = "core.exe";
            #endregion

            appConsole.Focus();
            //menuCtrl.SelectedIndex = 0;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            switch (File.Exists(corePathExe))
            {
                case true:
                    if (!File.Exists(corePathExe)) return;
                    appConsole.StartProcess("cmd", $"/c {corePathExe}");
                    break;
                case false:
                    if (!File.Exists(corePath)) return;
                    appConsole.StartProcess("cmd", $"/c @python {corePath}");
                    break;
                default:
                    break;
            }

            /*
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python";
            startInfo.Arguments = corePath;
            startInfo.UseShellExecute = true;

            Process.Start(startInfo);
            */

            menuCtrl.SelectedIndex = 1;

            if (closeCheck.Checked) this.WindowState = FormWindowState.Minimized;
        }

        private void configureBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        private void appConsole_Load(object sender, EventArgs e)
        {
            appConsole.WriteOutput("[i] Application GUI loaded.\n", Color.DarkCyan);
        }
    }
}
