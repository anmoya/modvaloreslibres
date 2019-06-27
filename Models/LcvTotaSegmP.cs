using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvTotaSegmP
    {
        public LcvTotaSegmP()
        {
            LcvSegmNoreP = new HashSet<LcvSegmNoreP>();
        }

        public decimal CorrLicv { get; set; }
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string TipoImpu { get; set; }
        public string CantDocu { get; set; }
        public string OperExen { get; set; }
        public string MontExen { get; set; }
        public string MontNeto { get; set; }
        public string OperVaag { get; set; }
        public string MontVaag { get; set; }
        public string OperFijo { get; set; }
        public string MontVafi { get; set; }
        public string OperIvac { get; set; }
        public string MontIvac { get; set; }
        public string MontLe18 { get; set; }
        public string ImpuSicr { get; set; }
        public string OperReto { get; set; }
        public string IvaRtto { get; set; }
        public string OperRtpa { get; set; }
        public string IvaRtpa { get; set; }
        public string MontCred { get; set; }
        public string MontEnva { get; set; }
        public string MontTota { get; set; }
        public string MontNret { get; set; }
        public string MontNofa { get; set; }
        public string MontPeri { get; set; }
        public string MontPana { get; set; }
        public string MontPain { get; set; }
        public string MontTapu { get; set; }
        public string MontTaci { get; set; }
        public string MontTael { get; set; }
        public string CodiEmex { get; set; }
        public string IvaFupl { get; set; }
        public decimal? OperNret { get; set; }
        public string TotaAnul { get; set; }
        public string VaagProp { get; set; }
        public string VaagTerc { get; set; }
        public string MontFijo { get; set; }

        public virtual LcvResuLibrP Co { get; set; }
        public virtual ICollection<LcvSegmNoreP> LcvSegmNoreP { get; set; }
    }
}
