using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDocuLob
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string TipoArch { get; set; }
        public string ClobDocu { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
