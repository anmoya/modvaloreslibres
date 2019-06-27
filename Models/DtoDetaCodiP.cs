using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoDetaCodiP
    {
        public decimal? CodiEmpr { get; set; }
        public decimal CorrDocu { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public string CorrCodi { get; set; }
        public string TipoCodi { get; set; }
        public string CodiItem { get; set; }
        public string MnsgErro { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DtoDetaPrseP DtoDetaPrseP { get; set; }
    }
}
