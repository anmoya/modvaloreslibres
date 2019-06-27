using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvSegmNore
    {
        public decimal CorrLicv { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal CodiNore { get; set; }
        public decimal? OperNore { get; set; }
        public decimal? MontNore { get; set; }
        public string CodiEmex { get; set; }

        public virtual LcvTotaSegm LcvTotaSegm { get; set; }
    }
}
