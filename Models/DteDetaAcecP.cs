using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDetaAcecP
    {
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public decimal CorrAcec { get; set; }
        public string CodiAcec { get; set; }
        public string MnsgErro { get; set; }

        public virtual DteEncaDocuP DteEncaDocuP { get; set; }
    }
}
