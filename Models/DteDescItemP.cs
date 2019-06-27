using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDescItemP
    {
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrDeit { get; set; }
        public string TipoDesc { get; set; }
        public string ValoDesc { get; set; }
        public string MnsgErro { get; set; }

        public virtual DteDetaPrseP DteDetaPrseP { get; set; }
    }
}
