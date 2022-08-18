using PireksCihazEntegrasyonu.Db;
using PireksCihazEntegrasyonu.Devices;
using System;
using System.Windows.Forms;

namespace PireksCihazEntegrasyonu.DeviceUI
{
    public partial class TunaylarLoadLine2UserControl : UserControl
    {
        public TunaylarLoadLine2UserControl()
        {
            InitializeComponent();
        }

        public TunaylarLoadLine2 Device { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Start();
        }

        private void Start()
        {
            var argumans = ApplicationParams.Instance.GetAracArgumans();
            textBoxPlaka.Text = argumans?.Y48PLAKA;
            textBoxTuru.Text = (argumans?.Y48GCTUR == 1 ? "GİRİŞ AĞIRLIĞI" : (argumans?.Y48GCTUR == 2 ? "ÇIKIŞ AĞIRLIĞI" : "BİLİNMİYOR"));

            Device = new TunaylarLoadLine2();
            Device.Configurations = Settings.Instance.Configuration.Settings;
            Device.Result += Device_Result;
            Device.Start();
        }

        private void Device_Result(object sender, TunaylarLoadLine2Result e)
        {
            this.Invoke(new Action(() =>
            {
                textBoxNet.Text = e.Sonuc;
            }));
        }

        protected override void DestroyHandle()
        {
            Device?.Stop();
            base.DestroyHandle();
        }

        private void buttonTartimiKaydet_Click(object sender, EventArgs e)
        {
            Device?.OkumayiBaslat();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        void Kaydet()
        {
            var argumans = ApplicationParams.Instance.GetAracArgumans();

            if (argumans == null)
                throw new Exception("Araç tartım için gerekli parametreler set edilmemiş!");

            var net = float.Parse(textBoxNet.Text);
            var ip = Tools.GetIP();

            DbTool.Instance.InsertAracTartim(argumans.Y48SIRKOD, argumans.Y48GCTUR, argumans.Y48USER, argumans.Y48HARNO, argumans.Y48PLAKA, argumans.Y48HARTAR, argumans.Y48KAPINO, net);

            Logger.WriteInfo($"{textBoxPlaka.Text} plakalı aracın {textBoxTuru.Text} ağırlığı {net} kg. olarak başarıyla kayıt edildi.");
            Application.Exit();
        }

        private void textBoxNet_TextChanged_1(object sender, EventArgs e)
        {
            labelGenelNetToplamBilgi.Text = $"{textBoxNet.Text} KG.";
        }
    }
}
