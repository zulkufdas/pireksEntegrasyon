using PireksCihazEntegrasyonu.Devices.Base.Configs;

namespace PireksCihazEntegrasyonu.Devices.Base
{
    internal abstract class BaseDevice <DeviceConfigType> where DeviceConfigType : BaseDeviceConfig
    {
        public DeviceConfigType Configurations { get; set; }

        public abstract void Start();
        public abstract void Stop();

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
