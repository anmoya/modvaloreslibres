using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteTidoEnviH
    {
        public decimal CorrEnvi { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal? CantDocu { get; set; }

        public virtual DteEnviDocuH CorrEnviNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
    }
}
