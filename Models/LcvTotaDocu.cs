using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvTotaDocu
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrLicv { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal RuttAsoc { get; set; }
        public string CodiImpu { get; set; }
        public decimal? TasImpu { get; set; }
        public decimal? MontImpu { get; set; }
        public string CodiEmex { get; set; }
        public decimal? CodiOper { get; set; }

        public virtual LcvDetaDocu LcvDetaDocu { get; set; }
    }
}
