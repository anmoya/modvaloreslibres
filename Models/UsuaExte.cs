using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class UsuaExte
    {
        public UsuaExte()
        {
            UsemExte = new HashSet<UsemExte>();
        }

        public string CodiUsex { get; set; }
        public string NombUsex { get; set; }
        public string PassUsex { get; set; }
        public string StatUsex { get; set; }
        public DateTime? FeinUsex { get; set; }
        public DateTime? FeteUsex { get; set; }
        public string MailUsex { get; set; }
        public string PassUsar { get; set; }
        public decimal? CodiEmpr { get; set; }
        public string CodiCeco { get; set; }
        public string CodiPers { get; set; }
        public string CodiEmex { get; set; }
        public string FonoUsex { get; set; }
        public string LugaUsex { get; set; }
        public string NocoUsex { get; set; }
        public string NombTabl { get; set; }
        public string Par1 { get; set; }
        public string Par2 { get; set; }
        public string Par3 { get; set; }
        public string Par4 { get; set; }
        public string Par5 { get; set; }
        public string Par6 { get; set; }
        public string Val1 { get; set; }
        public string Val2 { get; set; }
        public string Val3 { get; set; }
        public string Val4 { get; set; }
        public string Val5 { get; set; }
        public string Val6 { get; set; }

        public virtual CentCost Codi { get; set; }
        public virtual EmprExte CodiEmexNavigation { get; set; }
        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual Personas CodiPersNavigation { get; set; }
        public virtual ICollection<UsemExte> UsemExte { get; set; }
    }
}
