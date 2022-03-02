using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace ObjectMeasurement
{
    public class CoreSettings
    {
        private class CoreProperties
        {
            public bool useWebcam { get; set; }
            public int webcamIndex { get; set; }
            public string imgFilePath { get; set; }
            public int generalScale { get; set; }
            public int dashGapScale { get; set; }
            public string resolution { get; set; }
            public string windowName { get; set; }
        }

        private bool a_useWebcam { get; set; }
        private int a_webcamIndex { get; set; }
        private string a_imgFilePath { get; set; }
        private int a_generalScale { get; set; }
        private int a_dashGapScale { get; set; }
        private string a_resolution { get; set; }
        private string a_windowName { get; set; }


        public bool useWebcam { get; private set; }
        public int webcamIndex { get; private set; }
        public string imgFilePath { get; private set; }
        public int generalScale { get; private set; }
        public int dashGapScale { get; private set; }
        public string resolution { get; private set; }
        public string windowName { get; private set; }

        private string jsonPath { get; set; }

        public CoreSettings(string _jsonPath)
        {
            jsonPath = _jsonPath;
            LoadJson();
        }

        public void Configure(bool _useWebcam, int _webcamIndex,
            string _imgFilePath, int _generalScale,
            int _dashGapScale, string _resolution, string _windowName)
        {
            useWebcam = _useWebcam;
            webcamIndex = _webcamIndex;
            imgFilePath = _imgFilePath;
            generalScale = _generalScale;
            dashGapScale = _dashGapScale;
            resolution = _resolution;
            windowName = _windowName;

            //
            a_useWebcam = _useWebcam;
            a_webcamIndex = _webcamIndex;
            a_imgFilePath = _imgFilePath;
            a_generalScale = _generalScale;
            a_dashGapScale = _dashGapScale;
            a_resolution = _resolution;
            a_windowName = _windowName;
        }

        public void LoadJson()
        {
            string json = File.ReadAllText(jsonPath);
            CoreProperties loadedSettings = JsonConvert.DeserializeObject<CoreProperties>(json);
            Configure(loadedSettings.useWebcam, loadedSettings.webcamIndex, 
                loadedSettings.imgFilePath, loadedSettings.generalScale, loadedSettings.dashGapScale, 
                loadedSettings.resolution, loadedSettings.windowName);
        }

        public void Save()
        {
            CoreProperties properties = new CoreProperties
            {
                useWebcam = a_useWebcam,
                webcamIndex = a_webcamIndex,
                imgFilePath = a_imgFilePath,
                generalScale = a_generalScale,
                dashGapScale = a_dashGapScale,
                resolution = a_resolution,
                windowName = a_windowName
            };

            string writeJson = JsonConvert.SerializeObject(properties).ToString();
            
            /*
            Dictionary<string, string> replacePairs = new Dictionary<string, string>();
            replacePairs.Add("_useWebcam", "useWebcam");
            replacePairs.Add("_webcamIndex", "webcamIndex");
            replacePairs.Add("_imgFilePath", "imgFilePath");
            replacePairs.Add("_generalScale", "generalScale");
            replacePairs.Add("_dashGapScale", "dashGapScale");
            replacePairs.Add("_resolution", "resolution");
            replacePairs.Add("_windowName", "windowName");
            replacePairs.Add("_", "");

            foreach (KeyValuePair<string, string> item in replacePairs)
            {
                string key = item.Key;
                writeJson.Replace(key.ToString(), item.Value.ToString());
            }
            */

            // System.Windows.Forms.MessageBox.Show(JsonConvert.SerializeObject(properties));

            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(properties));
        }
    }
}
