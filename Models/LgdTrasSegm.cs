using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdTrasSegm
    {
        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal CodiTras { get; set; }
        public decimal? TipoTras { get; set; }
        public decimal? CantGuia { get; set; }
        public decimal? MontGuia { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdTotaSegm Co { get; set; }
    }
}
