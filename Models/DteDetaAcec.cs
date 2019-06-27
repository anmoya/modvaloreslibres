using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDetaAcec
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal CorrAcec { get; set; }
        public string CodiAcec { get; set; }
        public string MnsgErro { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteAcecEmpr Codi { get; set; }
        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
