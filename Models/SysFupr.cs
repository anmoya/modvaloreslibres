using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysFupr
    {
        public string CorrFupr { get; set; }
        public string CodiPeri { get; set; }
        public string ObjectRela { get; set; }
        public string CodiRous { get; set; }
        public string CodiUsua { get; set; }
        public string ObjectName { get; set; }
        public string Val1 { get; set; }
        public string Val2 { get; set; }
        public string Val3 { get; set; }
        public string Val4 { get; set; }
        public string Val5 { get; set; }
        public string EstaFupr { get; set; }
        public DateTime? FechFupr { get; set; }
        public string IndiFupr { get; set; }
        public string FreqFupr { get; set; }
        public string DescFupr { get; set; }
        public string Val6 { get; set; }

        public virtual SysObject ObjectNameNavigation { get; set; }
        public virtual SysObject ObjectRelaNavigation { get; set; }
    }
}
