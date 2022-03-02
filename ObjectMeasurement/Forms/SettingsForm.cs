using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectMeasurement
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm;

        public SettingsForm(MainForm mForm)
        {
            InitializeComponent();
            settings_visualSource.SelectedIndex = 1;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            mainForm = mForm;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool _useWebcam = settings_visualSource.SelectedItem.ToString() == "Web Camera";
            int _webcamIndex = Convert.ToInt32(settings_WebcamIndex.Value);
            string _imgFilePath = settings_ImageFile.Text.ToString();
            int _generalScale = Convert.ToInt32(settings_GeneralScale.Value);
            int _dashGapScale = Convert.ToInt32(settings_DashGapScale.Value);
            string _resolution = settings_Resolution.Text.ToString();
            string _windowName = settings_WindowTitle.Text.ToString();

            MainForm.coreSettings.Configure(_useWebcam, _webcamIndex, _imgFilePath, _generalScale, _dashGapScale, _resolution, _windowName);
            MainForm.coreSettings.Save();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            CoreSettings core = MainForm.coreSettings;
            core.LoadJson();
            if (core.useWebcam)
            {
                settings_visualSource.SelectedIndex = 0;
            }
            else
            {
                settings_visualSource.SelectedIndex = 1;
            }

            settings_WebcamIndex.Value = core.webcamIndex;
            settings_ImageFile.Text = core.imgFilePath;
            settings_GeneralScale.Value = core.generalScale;
            settings_DashGapScale.Value = core.dashGapScale;
            settings_Resolution.Text = core.resolution;
            settings_WindowTitle.Text = core.windowName;
        }
    }
}
