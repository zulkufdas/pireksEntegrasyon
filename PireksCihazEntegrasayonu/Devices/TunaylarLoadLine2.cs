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
        int say = 0;
        public override void Receive(string message)
        {
            if (!oku)
                return;

            try
            {
                say++;
                Logger.WriteInfo("mainMessageSayı =>" + say.ToString());

                if (say > 10)
                {
                    say = 0;
                    oku = false;

                    return;
                }

                base.Receive(message);

                mainMessage += message;

                Logger.WriteInfo("mainMessage1 =>" + mainMessage);

                var stxIndex = mainMessage.IndexOf(SinyalListesi.CharSinyalListesi.STX);
                var etxIndex = mainMessage.IndexOf(SinyalListesi.CharSinyalListesi.ETX);
                string sonuc = null;
                if (stxIndex > -1 && etxIndex > -1 && etxIndex > stxIndex)
                {
                    Logger.WriteInfo("mainMessage2 =>" + mainMessage);

                    var msg = mainMessage.Substring(stxIndex + 1, etxIndex - stxIndex);
                    Logger.WriteInfo("mainMessage3 =>" + msg);

                    //sonuc = msg.Substring(4, 5);
                    //sonuc = sonuc.Trim('0');
                    var items = msg.Split(' ');
                    sonuc = items[1].TrimStart('0');
                    mainMessage = string.Empty;

                    Result?.Invoke(this, new TunaylarLoadLine2Result
                    {
                        Sonuc = sonuc
                    });

                    oku = false;
                    say = 0;

                    return;
                }
            }
            catch (Exception ex)
            {
                oku = false;
                say = 0;
                Logger.WriteError(ex);
            }
            //else
            //    return;

            //Result?.Invoke(this, new TunaylarLoadLine2Result
            //{
            //    Sonuc = sonuc
            //});
        }

        bool oku = false;

        public void OkumayiBaslat()
        {
            string sendText = Convert.ToChar(2).ToString() + Convert.ToChar(Convert.ToInt32("1")).ToString() + "DNG" + Convert.ToChar(13).ToString();
            this.Send(sendText);
            oku = true;
            Oku();
        }

        public void Oku()
        {
            try
            {
                var message = this.ReadData();

                Logger.WriteInfo("Gelen Paket =>" + message);

                var stxIndex = message.IndexOf(SinyalListesi.CharSinyalListesi.STX);
                var etxIndex = message.IndexOf(SinyalListesi.CharSinyalListesi.ETX, stxIndex);
                while (stxIndex > -1 && etxIndex - stxIndex < 11)
                {
                    stxIndex = message.IndexOf(SinyalListesi.CharSinyalListesi.STX, stxIndex+1);
                    etxIndex = message.IndexOf(SinyalListesi.CharSinyalListesi.ETX, stxIndex);
                }
                string sonuc = null;
                if (stxIndex > -1 && etxIndex > -1 && etxIndex > stxIndex)
                {
                    var msg = message.Substring(stxIndex + 1, etxIndex - stxIndex - 1);
                    var items = msg.Split(' ');
                    sonuc = items[1].TrimStart('0');
                    message = string.Empty;

                    Result?.Invoke(this, new TunaylarLoadLine2Result
                    {
                        Sonuc = sonuc
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.WriteError(ex);
            }

        }
    }

    public class TunaylarLoadLine2Result
    {
        public string Sonuc { get; set; }
    }
}
