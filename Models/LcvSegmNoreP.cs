using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvSegmNoreP
    {
        public decimal CorrLicv { get; set; }
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string CodiNore { get; set; }
        public string OperNore { get; set; }
        public string MontNore { get; set; }
        public string CodiEmex { get; set; }

        public virtual LcvTotaSegmP LcvTotaSegmP { get; set; }
    }
}
