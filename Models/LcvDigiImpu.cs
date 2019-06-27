using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvDigiImpu
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string TipoOper { get; set; }
        public decimal RuttAsoc { get; set; }
        public string CodiImpu { get; set; }
        public decimal TasaImpu { get; set; }
        public decimal? MontImpu { get; set; }

        public virtual LcvDigiDocu LcvDigiDocu { get; set; }
    }
}
