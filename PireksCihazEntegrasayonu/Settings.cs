using PireksCihazEntegrasyonu.Devices;
using PireksCihazEntegrasyonu.Devices.Base;
using System;
using System.IO;

namespace PireksCihazEntegrasyonu
{
    internal class Settings
    {
        string settingFile = "DeviceSettings.json";
        Settings()
        {
            LoadSettings();
        }

        internal static Settings Instance { get;  } = new Lazy<Settings>(() => new Settings()).Value;

        public Configuration Configuration { get; set; }


        void LoadSettings()
        { try
            {
                if (File.Exists(settingFile))
                {
                    var jsonContent = File.ReadAllText(settingFile);
                    Configuration = Newtonsoft.Json.JsonConvert.DeserializeObject<Configuration>(jsonContent);
                }
            }
            finally {
                if (Configuration == null) {
                    Configuration = new Configuration();
                    Configuration.Settings = new Devices.Base.Configs.SerialDeviceConfig();
                }
            }
        }

        internal void SaveSettings()
        {
            var configurationContent = Newtonsoft.Json.JsonConvert.SerializeObject(Configuration);
            File.WriteAllText(settingFile, configurationContent);
        }

        public DeviceMap GetDeviceMap() {
            if (Configuration != null) {
                DeviceMap deviceMap = DeviceMappings.Instance.GetDeviceMap(Configuration.DeviceKey);
                return deviceMap;
            }

            return null;
        }
    }
}
