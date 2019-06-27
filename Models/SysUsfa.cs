using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysUsfa
    {
        public string CodiUsua { get; set; }
        public string ObjectName { get; set; }
        public decimal? OrdeUsfa { get; set; }
        public string ObjectRela { get; set; }
        public string ObjectType { get; set; }
        public string ObjectBrief { get; set; }
        public string ComeUsfa { get; set; }
        public string ObjectOrun { get; set; }
        public decimal? ObjectLevel { get; set; }
        public string ObjectOrder { get; set; }
        public string ObjectFreq { get; set; }

        public virtual UsuaSist CodiUsuaNavigation { get; set; }
    }
}
