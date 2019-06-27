using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoSumaImpuH
    {
        public decimal CorrDocu { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string CodiImpu { get; set; }
        public decimal? MontImpu { get; set; }
        public string MnsgErro { get; set; }
        public decimal? TasaImpu { get; set; }
    }
}
