using PireksCihazEntegrasyonu.Devices.Base;
using System;
using System.Windows.Forms;

namespace PireksCihazEntegrasyonu.DeviceUI
{
    public partial class DeviceSettingsForm : Form
    {
        public DeviceSettingsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            propertyGrid.SelectedObject = Tools.Clone(Settings.Instance.Configuration);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configuration configs = (Configuration)propertyGrid.SelectedObject;
            Settings.Instance.Configuration = configs;
            Settings.Instance.SaveSettings();

            DialogResult = DialogResult.OK;
        }
    }
}
