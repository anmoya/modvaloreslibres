using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdEncaLigd
    {
        public LgdEncaLigd()
        {
            LgdDetaDocu = new HashSet<LgdDetaDocu>();
        }

        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal? RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public string CodiPeri { get; set; }
        public string TipoLibr { get; set; }
        public string TipoSegm { get; set; }
        public decimal? NumeSegm { get; set; }
        public decimal? FoliNoti { get; set; }
        public string FehoFirm { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdTotaPeri LgdTotaPeri { get; set; }
        public virtual LgdTotaSegm LgdTotaSegm { get; set; }
        public virtual ICollection<LgdDetaDocu> LgdDetaDocu { get; set; }
    }
}
