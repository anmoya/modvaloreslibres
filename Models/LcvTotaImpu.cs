using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvTotaImpu
    {
        public decimal CorrLicv { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public string CodiImpu { get; set; }
        public decimal? MontImpu { get; set; }
        public decimal? FactAdic { get; set; }
        public decimal? MontCila { get; set; }
        public decimal? CodiEmex { get; set; }
    }
}
