using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteTidoEnvi
    {
        public decimal CorrEnvi { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal? CantDocu { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEnviDocu CorrEnviNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
    }
}
