using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdTotaPeri
    {
        public LgdTotaPeri()
        {
            LgdTrasPeri = new HashSet<LgdTrasPeri>();
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
        public virtual ICollection<LgdTrasPeri> LgdTrasPeri { get; set; }
    }
}
