using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeResuSegm
    {
        public LbeResuSegm()
        {
            LbeSegmTise = new HashSet<LbeSegmTise>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal CorrLibe { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal? CantAnul { get; set; }

        public virtual LbeCaraLibr Co { get; set; }
        public virtual ICollection<LbeSegmTise> LbeSegmTise { get; set; }
    }
}
