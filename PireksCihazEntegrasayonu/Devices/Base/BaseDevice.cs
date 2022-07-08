using PireksCihazEntegrasyonu.Devices.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu.Devices
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
