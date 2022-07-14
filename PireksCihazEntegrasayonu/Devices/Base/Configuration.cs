using PireksCihazEntegrasyonu.Devices.Base.Configs;

namespace PireksCihazEntegrasyonu.Devices.Base
{
    public class Configuration
    {
        public string DeviceKey { get; set; }
        public SerialDeviceConfig Settings { get; set; }
    }
}
