using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteAcecEmpr
    {
        public DteAcecEmpr()
        {
            DteDetaAcec = new HashSet<DteDetaAcec>();
            DteDetaAcecH = new HashSet<DteDetaAcecH>();
        }

        public decimal CodiEmpr { get; set; }
        public string CodiAcec { get; set; }
        public string CodiEmex { get; set; }

        public virtual DteActiEcon CodiAcecNavigation { get; set; }
        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual ICollection<DteDetaAcec> DteDetaAcec { get; set; }
        public virtual ICollection<DteDetaAcecH> DteDetaAcecH { get; set; }
    }
}
