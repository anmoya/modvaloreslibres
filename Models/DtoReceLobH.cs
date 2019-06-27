using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoReceLobH
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrRece { get; set; }
        public string TipoArch { get; set; }
        public string ClobDocu { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
    }
}
