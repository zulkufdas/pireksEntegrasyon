using PireksCihazEntegrasyonu.Args;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu
{
    public class ApplicationParams
    {
        IArgumans argumans;
        private ApplicationParams()
        {
            
        }
        public static ApplicationParams Instance { get; set; } = new Lazy<ApplicationParams>(() => new ApplicationParams()).Value;

        public void SetArgumans(IArgumans argumans) => this.argumans = argumans;

        public UrunArgumans GetUrunArgumans() => (UrunArgumans)argumans;
        public AracArgumans GetAracArgumans() => (AracArgumans)argumans;


    }
}
