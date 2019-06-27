using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysAlri
    {
        public string CodiAlar { get; set; }
        public string CodiRous { get; set; }
        public string CodiModu { get; set; }

        public virtual SysAlar CodiAlarNavigation { get; set; }
    }
}
