using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDescRecaP
    {
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string NumeDere { get; set; }
        public string TipoDere { get; set; }
        public string GlosDere { get; set; }
        public string TipoValo { get; set; }
        public string ValoDere { get; set; }
        public string IndiExen { get; set; }
        public string MnsgErro { get; set; }
        public decimal? VomoDere { get; set; }

        public virtual DteEncaDocuP DteEncaDocuP { get; set; }
    }
}
