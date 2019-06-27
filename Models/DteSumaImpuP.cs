using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteSumaImpuP
    {
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string CodiImpu { get; set; }
        public string MontImpu { get; set; }
        public string MnsgErro { get; set; }
        public string TasaImpu { get; set; }

        public virtual DteEncaDocuP DteEncaDocuP { get; set; }
    }
}
