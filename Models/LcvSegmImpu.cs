using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvSegmImpu
    {
        public decimal CorrLicv { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public string CodiImpu { get; set; }
        public decimal? MontImpu { get; set; }
        public string CodiEmex { get; set; }
    }
}
