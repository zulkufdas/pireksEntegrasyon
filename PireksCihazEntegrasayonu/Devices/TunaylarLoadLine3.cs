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
        string mainMessage = "";
        public override void Receive(string message)
        {
            base.Receive(message);

            Logger.WriteInfo("Gelen Paket =>" + message);

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

            Result?.Invoke(this, new TunaylarLoadLine3Result
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
            //Oku();
        }

        public override void Start()
        {
            base.Start();
            StartListen();
        }

        public void Oku()
        {
            try
            {
                var message = this.ReadData();

                Logger.WriteInfo("Gelen Paket =>" + message);

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

                Result?.Invoke(this, new TunaylarLoadLine3Result
                {
                    Sonuc = sonuc,
                    IsDara = isDara
                });
            }
            catch (Exception ex)
            {
                Logger.WriteError(ex);
            }

        }
    }

    public class TunaylarLoadLine3Result
    {
        public string Sonuc { get; set; }
        public bool IsDara { get; set; }
    }
}
