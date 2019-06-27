using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysAlin
    {
        public decimal CodiAlin { get; set; }
        public string CodiAlar { get; set; }
        public string CodiUsua { get; set; }
        public string Val1 { get; set; }
        public string Val2 { get; set; }
        public string Val3 { get; set; }
        public string Val4 { get; set; }
        public string Val5 { get; set; }
        public string Val6 { get; set; }
        public string CodiEmex { get; set; }
        public decimal? CodiEmpr { get; set; }

        public virtual SysAlar CodiAlarNavigation { get; set; }
    }
}
