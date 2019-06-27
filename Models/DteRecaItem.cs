using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteRecaItem
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrReit { get; set; }
        public string TipoReca { get; set; }
        public decimal? ValoReca { get; set; }
        public string MnsgErro { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteDetaPrse DteDetaPrse { get; set; }
    }
}
