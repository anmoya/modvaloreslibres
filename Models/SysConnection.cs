using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysConnection
    {
        public decimal CorrConn { get; set; }
        public string CodiUsex { get; set; }
        public string CodiUsua { get; set; }
        public decimal CorrSess { get; set; }
        public DateTime? FeinConn { get; set; }

        public virtual SysSession CorrSessNavigation { get; set; }
    }
}
