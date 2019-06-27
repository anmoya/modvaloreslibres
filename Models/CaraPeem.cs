using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class CaraPeem
    {
        public decimal CodiEmpr { get; set; }
        public string CodiPers { get; set; }
        public DateTime FeinCape { get; set; }
        public DateTime? FeteCape { get; set; }
        public string CodiCage { get; set; }
        public string CodiVacg { get; set; }
        public decimal? ValoCape { get; set; }
        public string ComeCape { get; set; }
        public string CodiEmex { get; set; }

        public virtual ValoCage Codi { get; set; }
        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual Personas CodiPersNavigation { get; set; }
    }
}
