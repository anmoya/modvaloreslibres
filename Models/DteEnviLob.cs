using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteEnviLob
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrEnvi { get; set; }
        public string TipoArch { get; set; }
        public string ClobDocu { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
    }
}
