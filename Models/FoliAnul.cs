using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class FoliAnul
    {
        public decimal CodiEmpr { get; set; }
        public decimal CodiZona { get; set; }
        public string CodiOfic { get; set; }
        public string TipoComo { get; set; }
        public decimal FoliFoan { get; set; }
        public DateTime FechFoan { get; set; }
        public decimal? CodiEmpl { get; set; }
        public string CodiCeco { get; set; }
        public string CodiConf { get; set; }

        public virtual CentCost Codi { get; set; }
        public virtual Empr CodiEmprNavigation { get; set; }
    }
}
