using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDocuLobH
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string TipoArch { get; set; }
        public string ClobDocu { get; set; }

        public virtual DteEncaDocuH DteEncaDocuH { get; set; }
    }
}
