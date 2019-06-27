using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDescRecaH
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeDere { get; set; }
        public string TipoDere { get; set; }
        public string GlosDere { get; set; }
        public string TipoValo { get; set; }
        public decimal? ValoDere { get; set; }
        public decimal? IndiExen { get; set; }
        public string MnsgErro { get; set; }
        public decimal? VomoDere { get; set; }

        public virtual DteEncaDocuH DteEncaDocuH { get; set; }
    }
}
