using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class CaraPers
    {
        public string CodiPers { get; set; }
        public DateTime FeinCape { get; set; }
        public DateTime? FeteCape { get; set; }
        public string CodiCage { get; set; }
        public string CodiVacg { get; set; }
        public decimal? ValoCape { get; set; }
        public string ComeCape { get; set; }
        public string CodiEmex { get; set; }

        public virtual Personas CodiPersNavigation { get; set; }
    }
}
