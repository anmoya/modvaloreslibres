using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysInst
    {
        public string ObjectName { get; set; }
        public decimal ObjectNumber { get; set; }
        public decimal? ObjectOrder { get; set; }

        public virtual SysObject ObjectNameNavigation { get; set; }
    }
}
