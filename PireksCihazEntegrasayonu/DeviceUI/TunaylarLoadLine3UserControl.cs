using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PireksCihazEntegrasyonu.Devices;

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
            Device.Receive
            Device.Start();
        }

        protected override void DestroyHandle()
        {
            Device?.Stop();
            base.DestroyHandle();
        }
    }
}
