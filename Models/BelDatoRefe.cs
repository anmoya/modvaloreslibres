using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelDatoRefe
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public string CodiRefe { get; set; }
        public string RazoRefe { get; set; }
        public string CodiVend { get; set; }
        public string CodiCaja { get; set; }

        public virtual BelEncaDocu BelEncaDocu { get; set; }
    }
}
