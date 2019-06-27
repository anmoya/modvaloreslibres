using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvResuLibrP
    {
        public LcvResuLibrP()
        {
            LcvTotaSegmP = new HashSet<LcvTotaSegmP>();
        }

        public decimal CorrLicv { get; set; }
        public decimal CodiEmpr { get; set; }
        public string RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public string CodiPeri { get; set; }
        public string TipoOper { get; set; }
        public string TipoLibr { get; set; }
        public string TipoSegm { get; set; }
        public string NumeSegm { get; set; }
        public string FehoFirm { get; set; }
        public string VersLicv { get; set; }
        public string NumeNoti { get; set; }
        public string CodiEmex { get; set; }

        public virtual ICollection<LcvTotaSegmP> LcvTotaSegmP { get; set; }
    }
}
