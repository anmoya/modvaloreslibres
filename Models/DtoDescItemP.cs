using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoDescItemP
    {
        public decimal? CodiEmpr { get; set; }
        public decimal CorrDocu { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrDeit { get; set; }
        public string TipoDesc { get; set; }
        public string ValoDesc { get; set; }
        public string MnsgErro { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DtoDetaPrseP DtoDetaPrseP { get; set; }
    }
}
