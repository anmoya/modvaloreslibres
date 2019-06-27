using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDescItemH
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrDeit { get; set; }
        public string TipoDesc { get; set; }
        public decimal? ValoDesc { get; set; }
        public string MnsgErro { get; set; }

        public virtual DteDetaPrseH DteDetaPrseH { get; set; }
    }
}
