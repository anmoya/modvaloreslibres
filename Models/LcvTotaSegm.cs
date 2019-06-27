using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvTotaSegm
    {
        public LcvTotaSegm()
        {
            LcvSegmNore = new HashSet<LcvSegmNore>();
        }

        public decimal CorrLicv { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal? TipoImpu { get; set; }
        public decimal? CantDocu { get; set; }
        public decimal? OperExen { get; set; }
        public decimal? MontExen { get; set; }
        public decimal? MontNeto { get; set; }
        public decimal? OperVaag { get; set; }
        public decimal? MontVaag { get; set; }
        public decimal? OperFijo { get; set; }
        public decimal? MontVafi { get; set; }
        public decimal? OperIvac { get; set; }
        public decimal? MontIvac { get; set; }
        public decimal? MontLe18 { get; set; }
        public decimal? ImpuSicr { get; set; }
        public decimal? OperReto { get; set; }
        public decimal? IvaRtto { get; set; }
        public decimal? OperRepa { get; set; }
        public decimal? IvaRtpa { get; set; }
        public decimal? MontCred { get; set; }
        public decimal? MontEnva { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontNret { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? MontPeri { get; set; }
        public decimal? MontPana { get; set; }
        public decimal? MontPain { get; set; }
        public decimal? MontTapu { get; set; }
        public decimal? MontTaci { get; set; }
        public decimal? MontTael { get; set; }
        public string CodiEmex { get; set; }
        public decimal? IvaFupl { get; set; }
        public decimal? OperNret { get; set; }
        public decimal? TotaAnul { get; set; }
        public decimal? VaagProp { get; set; }
        public decimal? VaagTerc { get; set; }
        public decimal? MontFijo { get; set; }

        public virtual LcvResuLibr Co { get; set; }
        public virtual ICollection<LcvSegmNore> LcvSegmNore { get; set; }
    }
}
