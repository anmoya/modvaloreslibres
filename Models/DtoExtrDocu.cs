using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoExtrDocu
    {
        public decimal CorrExtr { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal CorrDocu { get; set; }
        public string NombArch { get; set; }
    }
}
