using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelFoliAnul
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliAnul { get; set; }
        public string FechAnul { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
    }
}
