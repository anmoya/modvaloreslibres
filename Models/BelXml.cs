using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelXml
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string ClobDocu { get; set; }

        public virtual BelEncaDocu BelEncaDocu { get; set; }
    }
}
