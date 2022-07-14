using PireksCihazEntegrasyonu.Devices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu.Devices
{
    internal class TunaylarLoadLine3 : SerialPortDevice
    {
        public override void Receive(string message)
        {
            base.Receive(message);
        }
    }
}
