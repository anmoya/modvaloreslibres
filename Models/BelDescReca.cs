using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelDescReca
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public string TipoMov { get; set; }
        public string GlosMovi { get; set; }
        public string TipoValo { get; set; }
        public decimal? ValoMovi { get; set; }
        public decimal? IndiExen { get; set; }

        public virtual BelEncaDocu BelEncaDocu { get; set; }
    }
}
