using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoTrace
    {
        public decimal RuttEmis { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string FehoTrac { get; set; }
        public string EstaTrac { get; set; }
    }
}
