using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelDetaSubt
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal LineDeta { get; set; }

        public virtual BelSubtInfo BelSubtInfo { get; set; }
    }
}
