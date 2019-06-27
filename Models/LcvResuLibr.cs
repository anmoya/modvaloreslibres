using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvResuLibr
    {
        public LcvResuLibr()
        {
            LcvTotaLibr = new HashSet<LcvTotaLibr>();
            LcvTotaSegm = new HashSet<LcvTotaSegm>();
        }

        public decimal CorrLicv { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal? RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public string CodiPeri { get; set; }
        public string TipoOper { get; set; }
        public string TipoLibr { get; set; }
        public string TipoSegm { get; set; }
        public decimal? NumeSegm { get; set; }
        public string FehoFirm { get; set; }
        public string VersLicv { get; set; }
        public decimal? NumeNoti { get; set; }
        public string CodiEmex { get; set; }
        public decimal? NumeAten { get; set; }
        public string CodiRect { get; set; }
        public string EstaEnvi { get; set; }
        public string MensEnvi { get; set; }
        public decimal? NumeEnvi { get; set; }

        public virtual DteEstaEnvi EstaEnviNavigation { get; set; }
        public virtual ICollection<LcvTotaLibr> LcvTotaLibr { get; set; }
        public virtual ICollection<LcvTotaSegm> LcvTotaSegm { get; set; }
    }
}
