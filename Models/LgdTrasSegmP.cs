using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdTrasSegmP
    {
        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public string CodiTras { get; set; }
        public string TipoTras { get; set; }
        public string CantGuia { get; set; }
        public string MontGuia { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdTotaSegmP Co { get; set; }
    }
}
