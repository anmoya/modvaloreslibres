using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeTotaSegm
    {
        public LbeTotaSegm()
        {
            LbeServSegm = new HashSet<LbeServSegm>();
        }

        public decimal CorrLibe { get; set; }
        public decimal CodiSoli { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal? CantFoan { get; set; }
        public decimal? CodiEmpr { get; set; }

        public virtual LbeEncaLibr Co { get; set; }
        public virtual ICollection<LbeServSegm> LbeServSegm { get; set; }
    }
}
