using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoRecaItem
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrReit { get; set; }
        public string TipoReca { get; set; }
        public decimal? ValoReca { get; set; }
        public string MnsgErro { get; set; }

        public virtual DtoDetaPrse DtoDetaPrse { get; set; }
    }
}
