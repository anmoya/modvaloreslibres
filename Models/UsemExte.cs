using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class UsemExte
    {
        public string CodiUsex { get; set; }
        public string CodiEmex { get; set; }
        public string StatUeex { get; set; }
        public DateTime FeinUeex { get; set; }
        public DateTime? FeteUeex { get; set; }
        public string CodiPers { get; set; }

        public virtual EmprExte CodiEmexNavigation { get; set; }
        public virtual Personas CodiPersNavigation { get; set; }
        public virtual UsuaExte CodiUsexNavigation { get; set; }
    }
}
