using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysAlro
    {
        public string CodiAlar { get; set; }
        public string CodiRous { get; set; }
        public string CodiModu { get; set; }
        public string MailAlro { get; set; }

        public virtual SysAlar CodiAlarNavigation { get; set; }
    }
}
