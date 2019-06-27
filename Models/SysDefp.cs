using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysDefp
    {
        public string CorrDefp { get; set; }
        public string CorrFupr { get; set; }
        public string ObjectName { get; set; }
        public string EstaDefp { get; set; }
        public DateTime? FechDefp { get; set; }
        public string IndiDefp { get; set; }

        public virtual SysObject ObjectNameNavigation { get; set; }
    }
}
