using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelDetaCodi
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public string TipoCodi { get; set; }
        public string CodiItem { get; set; }

        public virtual BelDetaPrse BelDetaPrse { get; set; }
    }
}
