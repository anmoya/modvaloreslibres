using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDelCesion
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrCesi { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeCesi { get; set; }
        public string FechDel { get; set; }
        public string Motivo { get; set; }
        public string CodiPers { get; set; }
        public string ArchCesiDel { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
    }
}
