﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PireksCihazEntegrasyonu.Devices;
using PireksCihazEntegrasyonu.Db;

namespace PireksCihazEntegrasyonu.DeviceUI
{
    public partial class TunaylarLoadLine3UserControl : UserControl
    {
        public TunaylarLoadLine3UserControl()
        {
            InitializeComponent();
        }

        public TunaylarLoadLine3 Device { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Start();
        }

        private void Start()
        {
            Device = new TunaylarLoadLine3();
            Device.Configurations = Settings.Instance.Configuration.Settings;
            Device.Result += Device_Result;
            Device.Start();
        }

        private void Device_Result(object sender, TunaylarLoadLine3Result e)
        {
            this.Invoke(new Action(() =>
            {
                if (e.IsDara)
                    textBoxDara.Text = e.Sonuc;
                else
                    textBoxBrut.Text = e.Sonuc;

            }));
        }

        protected override void DestroyHandle()
        {
            Device?.Stop();
            base.DestroyHandle();
        }

        private void buttonDaraKaydet_Click(object sender, EventArgs e)
        {
            Device?.OkumayiBaslat(true);
        }

        private void buttonTartimiKaydet_Click(object sender, EventArgs e)
        {
            Device?.OkumayiBaslat(false);
        }

        private void textBoxBrut_TextChanged(object sender, EventArgs e)
        {
            labelGenelNetToplamBilgi.Text = $"{textBoxBrut.Text} KG.";
            NetHesapla();
        }

        private void textBoxDara_TextChanged(object sender, EventArgs e)
        {
            labelGenelNetToplamBilgi.Text = $"{textBoxDara.Text} KG.";
            NetHesapla();
        }

        void NetHesapla()
        {
            try
            {
                var brut = float.Parse(textBoxBrut.Text);
                var dara = float.Parse(textBoxDara.Text);
                var net = brut - dara;
                textBoxNet.Text = net.ToString();
            }
            catch
            {
                textBoxNet.Text = null;
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        void Kaydet()
        {

            var argumans = ApplicationParams.Instance.GetUrunArgumans();

            if (argumans == null)
                throw new Exception("Ürün tartım için gerekli parametreler set edilmemiş!");

            var brut = float.Parse(textBoxBrut.Text);
            var dara = float.Parse(textBoxDara.Text);
            var net = brut - dara;
            var ip = Tools.GetIP();

            DbTool.Instance.InsertUrunTartim(brut, dara, net, argumans.Y46SIRKOD, argumans.Y46ISERID, "1", ip, ip, argumans.Y46USER);

            Logger.WriteInfo($"Brüt: {brut} dara: {dara} net: {net} başarıyla kayıt edildi.");
            Application.Exit();
        }
    }
}
