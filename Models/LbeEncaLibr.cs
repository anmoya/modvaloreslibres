using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeEncaLibr
    {
        public LbeEncaLibr()
        {
            LbeDetaDocu = new HashSet<LbeDetaDocu>();
            LbeTotaPeri = new HashSet<LbeTotaPeri>();
            LbeTotaSegm = new HashSet<LbeTotaSegm>();
        }

        public decimal CorrLibe { get; set; }
        public decimal CodiSoli { get; set; }
        public decimal? CodiEmpr { get; set; }
        public decimal? RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public string CodiPeri { get; set; }
        public string TipoLibr { get; set; }
        public string TipoEnvi { get; set; }
        public decimal? NumeSegm { get; set; }
        public decimal? FoliNoti { get; set; }

        public virtual LbeSoliLibr CodiSoliNavigation { get; set; }
        public virtual ICollection<LbeDetaDocu> LbeDetaDocu { get; set; }
        public virtual ICollection<LbeTotaPeri> LbeTotaPeri { get; set; }
        public virtual ICollection<LbeTotaSegm> LbeTotaSegm { get; set; }
    }
}
