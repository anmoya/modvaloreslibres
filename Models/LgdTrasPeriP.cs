using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdTrasPeriP
    {
        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal CodiTras { get; set; }
        public string TipoTras { get; set; }
        public string CantGuia { get; set; }
        public string MontGuia { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdTotaPeriP Co { get; set; }
    }
}
