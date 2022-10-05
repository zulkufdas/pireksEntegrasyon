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
        //string mainMessage = "";
        public override void Receive(string message)
        {
            base.Receive(message);

           
            //Logger.WriteInfo("Gelen Paket =>" + message);

            if (message != null) {
                var start = message.IndexOf('N');
                var end = message.IndexOf('T',start);

                if (start > -1 && end > -1) {
                    var length = message.Substring(start, end)
                        ?.Replace("N", "")
                        ?.Replace("T", "")
                        ?.Replace("kg","")
                        ?.Replace(".",",")
                        ?.TrimEnd('0')
                        ?.TrimEnd(',');
                    length = length.TrimEnd().TrimStart();

                    Result?.Invoke(this, new HurayB2AB0066KResult
                    {
                        Sonuc = length,
                        IsDara = isDara
                    });
                }
            }
        }

        public void OkumayiBaslat(bool isDara)
        {
            this.isDara = isDara;

            //string sendText = Convert.ToChar(2).ToString() + Convert.ToChar(Convert.ToInt32("1")).ToString() + "DNG" + Convert.ToChar(13).ToString();
            //this.Send(sendText);
        }

        public override void Start()
        {
            base.Start();
            StartListen();
        }
    }

    public class HurayB2AB0066KResult
    {
        public string Sonuc { get; set; }
        public bool IsDara { get; set; }
    }
}
