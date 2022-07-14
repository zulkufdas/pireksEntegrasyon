using PireksCihazEntegrasyonu.DeviceUI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PireksCihazEntegrasyonu.Devices
{
    internal class DeviceMappings : List<DeviceMap>
    {
        DeviceMappings()
        {
            Load();
        }

        private void Load()
        {
            Add(new DeviceMap
            {
                Key = "TenaylarLoadLine3",
                Name = "Tenaylar Load Line 3",
                UserControl = typeof(TunaylarLoadLine3UserControl)
            });
        }

        internal static DeviceMappings Instance { get; set; } = new Lazy<DeviceMappings>(() => new DeviceMappings()).Value;

        internal DeviceMap GetDeviceMap(string deviceKey)
        {
            return this.FirstOrDefault(m => m.Key == deviceKey);
        }
    }

    internal class DeviceMap
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public Type UserControl { get; set; }
    }
}
