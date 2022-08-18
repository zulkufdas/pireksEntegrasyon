using PireksCihazEntegrasyonu.Devices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu.Devices
{
    public class TunaylarLoadLine2 : SerialPortDevice
    {
        public event EventHandler<TunaylarLoadLine2Result> Result;
        string mainMessage = "";
        public override void Receive(string message)
        {
            base.Receive(message);

            mainMessage += message;

            var stxIndex = mainMessage.IndexOf(SinyalListesi.CharSinyalListesi.STX);
            var etxIndex = mainMessage.IndexOf(SinyalListesi.CharSinyalListesi.ETX);
            string sonuc = null;
            if (stxIndex > -1 && etxIndex > -1)
            {
                var msg = mainMessage.Substring(stxIndex + 1, etxIndex - stxIndex);
                sonuc = msg.Substring(25, 5);
                sonuc = sonuc.Trim('0');
                mainMessage = string.Empty;
            }
            else
                return;

            Result?.Invoke(this, new TunaylarLoadLine2Result
            {
                Sonuc = sonuc
            });
        }

        public void OkumayiBaslat()
        {
            string sendText = Convert.ToChar(2).ToString() + Convert.ToChar(Convert.ToInt32("1")).ToString() + "DNG" + Convert.ToChar(13).ToString();
            this.Send(sendText);
        }
    }

    public class TunaylarLoadLine2Result
    {
        public string Sonuc { get; set; }
    }
}
