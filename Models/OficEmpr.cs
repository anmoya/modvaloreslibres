using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class OficEmpr
    {
        public OficEmpr()
        {
            DteRangFoli = new HashSet<DteRangFoli>();
        }

        public decimal CodiEmpr { get; set; }
        public string CodiOfic { get; set; }
        public string DescOfic { get; set; }
        public string CodiCeco { get; set; }
        public string CodiSii { get; set; }
        public string DireOfic { get; set; }
        public string CodiCiud { get; set; }
        public string CodiComu { get; set; }
        public string CodiPais { get; set; }
        public string FonoOfic { get; set; }
        public string FaxxOfic { get; set; }
        public string TelxOfic { get; set; }
        public string CodiEmex { get; set; }

        public virtual CentCost Codi { get; set; }
        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual ICollection<DteRangFoli> DteRangFoli { get; set; }
    }
}
