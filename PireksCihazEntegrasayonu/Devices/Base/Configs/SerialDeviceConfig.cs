﻿using System.IO.Ports;

namespace PireksCihazEntegrasyonu.Devices.Configs
{
    internal class SerialDeviceConfig : BaseDeviceConfig
    {
        //[DisplayName("Port Adı")]
        public string PortName { get; set; }

        public int BaudRate { get; set; } = 9600;

        public Parity Parity { get; set; } = Parity.None;

        public int DataBits { get; set; } = 8;

        public StopBits StopBits { get; set; } = StopBits.One;
    }
}