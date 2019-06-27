using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoDetaAcecH
    {
        public decimal CorrDocu { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal CorrAcec { get; set; }
        public string CodiAcec { get; set; }
        public string MnsgErro { get; set; }
    }
}
