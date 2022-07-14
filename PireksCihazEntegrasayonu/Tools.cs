using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu
{
    public static class Tools
    {
        public static object Clone(object value)
        {

            if (value != null)
            {
                var serialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(value);
                var clonedObject = Newtonsoft.Json.JsonConvert.DeserializeObject(serialzedObject, value.GetType());
                return clonedObject;
            }

            return null;
        }
    }
}
