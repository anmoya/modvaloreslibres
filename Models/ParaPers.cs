using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class ParaPers
    {
        public decimal CodiEmpr { get; set; }
        public string CodiPers { get; set; }
        public string TipoComo { get; set; }
        public string CodiPape { get; set; }
        public string ValoPape { get; set; }
        public string DescPape { get; set; }
        public string CodiEmex { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual Personas CodiPersNavigation { get; set; }
    }
}
