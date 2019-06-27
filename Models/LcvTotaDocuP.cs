using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvTotaDocuP
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrLicv { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string RuttAsoc { get; set; }
        public string CodiImpu { get; set; }
        public string TasImpu { get; set; }
        public string MontImpu { get; set; }
        public string CodiEmex { get; set; }

        public virtual LcvDetaDocuP LcvDetaDocuP { get; set; }
    }
}
