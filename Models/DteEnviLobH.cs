using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteEnviLobH
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrEnvi { get; set; }
        public string TipoArch { get; set; }
        public string ClobDocu { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
    }
}
