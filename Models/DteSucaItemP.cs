using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteSucaItemP
    {
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrSuca { get; set; }
        public string CodiSuca { get; set; }
        public string SucaDist { get; set; }
        public string MnsgErro { get; set; }

        public virtual DteDetaPrseP DteDetaPrseP { get; set; }
    }
}
