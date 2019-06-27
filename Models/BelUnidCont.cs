using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelUnidCont
    {
        public BelUnidCont()
        {
            BelAsigFoli = new HashSet<BelAsigFoli>();
        }

        public string CodiUnid { get; set; }
        public string NombUnid { get; set; }
        public decimal CodiEmpr { get; set; }
        public string CodiCeco { get; set; }
        public decimal CantFoli { get; set; }
        public decimal PorcRepo { get; set; }
        public string TipoOrig { get; set; }
        public string EstaUnid { get; set; }
        public string IndiAlta { get; set; }

        public virtual CentCost Codi { get; set; }
        public virtual ICollection<BelAsigFoli> BelAsigFoli { get; set; }
    }
}
