using PireksCihazEntegrasyonu.Devices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu.Devices
{
    public class HurayB2AB0066K : SerialPortDevice
    {
        public event EventHandler<HurayB2AB0066KResult> Result;
        bool isDara = false;
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

            Result?.Invoke(this, new HurayB2AB0066KResult
            {
                Sonuc = sonuc,
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

    public class HurayB2AB0066KResult
    {
        public string Sonuc { get; set; }
        public bool IsDara { get; set; }
    }
}
