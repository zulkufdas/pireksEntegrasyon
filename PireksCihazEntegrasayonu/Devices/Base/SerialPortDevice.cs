using PireksCihazEntegrasyonu.Devices.Base.Configs;
using System.IO.Ports;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu.Devices.Base
{
    public class SerialPortDevice : BaseDevice<SerialDeviceConfig>
    {
        SerialPort port;
        Task listenerTask = null;


        public override void Receive(string message)
        {
            Logger.WriteInfo("Receive =>" + message);
        }

        public override void Send(string message)
        {
            port.Write(message);
            Logger.WriteInfo("Send =>" + message);
        }

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
