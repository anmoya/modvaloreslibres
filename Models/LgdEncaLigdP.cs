using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdEncaLigdP
    {
        public LgdEncaLigdP()
        {
            LgdDetaDocuP = new HashSet<LgdDetaDocuP>();
        }

        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public string RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public string CodiPeri { get; set; }
        public string TipoLibr { get; set; }
        public string TipoSegm { get; set; }
        public string NumeSegm { get; set; }
        public string FoliNoti { get; set; }
        public string FehoFirm { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdTotaPeriP LgdTotaPeriP { get; set; }
        public virtual LgdTotaSegmP LgdTotaSegmP { get; set; }
        public virtual ICollection<LgdDetaDocuP> LgdDetaDocuP { get; set; }
    }
}
