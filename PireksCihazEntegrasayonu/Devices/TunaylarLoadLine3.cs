using PireksCihazEntegrasyonu.Devices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu.Devices
{
    public class TunaylarLoadLine3 : SerialPortDevice
    {
        public event EventHandler<TunaylarLoadLine3Result> Result;
        bool isDara = false;
        public override void Receive(string message)
        {
            base.Receive(message);

            Result?.Invoke(this, new TunaylarLoadLine3Result
            {
                Sonuc = "",
                IsDara = isDara
            });
        }

        public void OkumayiBaslat(bool isDara)
        {
            this.isDara = isDara;

            string sendText = Convert.ToChar(2).ToString() + Convert.ToChar(Convert.ToInt32("1")).ToString() + "DNG" + Convert.ToChar(13).ToString();
            this.Send(sendText);
        }
    }

    public class TunaylarLoadLine3Result
    {
        public string Sonuc { get; set; }
        public bool IsDara { get; set; }
    }
}
