using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteRecaItemP
    {
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrReit { get; set; }
        public string TipoReca { get; set; }
        public string ValoReca { get; set; }
        public string MnsgErro { get; set; }

        public virtual DteDetaPrseP DteDetaPrseP { get; set; }
    }
}
