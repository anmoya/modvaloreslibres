using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoDetaCodiH
    {
        public decimal CorrDocu { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrCodi { get; set; }
        public string TipoCodi { get; set; }
        public string CodiItem { get; set; }
        public string MnsgErro { get; set; }
    }
}
