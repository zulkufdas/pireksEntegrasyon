using PireksCihazEntegrasyonu.Devices.Configs;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu.Devices
{
    internal class SerialPortDevice : BaseDevice<SerialDeviceConfig>
    {
        SerialPort port;
        Task listenerTask = null;

        public override void Receive(string message)
        {

        }

        public override void Send(string message) => port.Write(message);

        public override void Start()
        {
            port = new SerialPort(Configurations.PortName, Configurations.BaudRate, Configurations.Parity, Configurations.DataBits);
            port.Open();
            StartListen();
        }

        void StartListen()
        {
            listenerTask?.Dispose();

            listenerTask = Task.Run(() =>
            {
                while (port.IsOpen)
                {
                    if (port.BytesToRead > 0)
                    {
                        Receive(port.ReadExisting());
                    }
                }
            });
        }

        public override void Stop()
        {
            port?.Close();
            listenerTask?.Dispose();
        }

    }
}
