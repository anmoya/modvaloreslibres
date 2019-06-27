using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysSession
    {
        public SysSession()
        {
            SysConnection = new HashSet<SysConnection>();
        }

        public decimal CorrSess { get; set; }
        public DateTime? FeinSess { get; set; }
        public DateTime? FeteSess { get; set; }
        public string CodiUsua { get; set; }
        public string CodiPers { get; set; }
        public string CodiRous { get; set; }
        public string CodiModu { get; set; }
        public decimal? CodiEmpr { get; set; }
        public string CodiCeco { get; set; }
        public string CodiMenu { get; set; }
        public string CodiDbst { get; set; }
        public string CodiEmex { get; set; }
        public string CodiCult { get; set; }

        public virtual ICollection<SysConnection> SysConnection { get; set; }
    }
}
