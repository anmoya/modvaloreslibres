using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeResuPeri
    {
        public LbeResuPeri()
        {
            LbePeriTise = new HashSet<LbePeriTise>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal CorrLibe { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal? CantAnul { get; set; }

        public virtual LbeCaraLibr Co { get; set; }
        public virtual ICollection<LbePeriTise> LbePeriTise { get; set; }
    }
}
