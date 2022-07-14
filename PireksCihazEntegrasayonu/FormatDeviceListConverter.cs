using PireksCihazEntegrasyonu.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu
{
    public class FormatDeviceListConverter : StringConverter
    {

        public override Boolean GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
        public override Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(DeviceMappings.Instance.Select(_ => _.Key).ToList());
        }
    }
}
