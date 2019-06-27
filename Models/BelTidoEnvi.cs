using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelTidoEnvi
    {
        public decimal CorrEnvi { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal CantDocu { get; set; }
        public decimal CodiEmpr { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual BelEnviDocu CorrEnviNavigation { get; set; }
    }
}
