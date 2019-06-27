using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdTotaSegm
    {
        public LgdTotaSegm()
        {
            LgdTrasSegm = new HashSet<LgdTrasSegm>();
        }

        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal? NumeFoan { get; set; }
        public decimal? NumeGanu { get; set; }
        public decimal? TotaGvta { get; set; }
        public decimal? MontGvta { get; set; }
        public decimal? MontModi { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdEncaLigd Co { get; set; }
        public virtual ICollection<LgdTrasSegm> LgdTrasSegm { get; set; }
    }
}
