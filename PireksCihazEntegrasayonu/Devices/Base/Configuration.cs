using PireksCihazEntegrasyonu.Devices.Base.Configs;
using System;
using System.ComponentModel;

namespace PireksCihazEntegrasyonu.Devices.Base
{
    public class Configuration 
    {
        [TypeConverter(typeof(FormatDeviceListConverter))]
        public string DeviceKey { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public SerialDeviceConfig Settings { get; set; }
    }
}
