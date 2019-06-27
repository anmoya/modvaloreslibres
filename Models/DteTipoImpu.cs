using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteTipoImpu
    {
        public DteTipoImpu()
        {
            DteDetaPrse = new HashSet<DteDetaPrse>();
            DteDetaPrseH = new HashSet<DteDetaPrseH>();
            DteSumaImpu = new HashSet<DteSumaImpu>();
            DteSumaImpuH = new HashSet<DteSumaImpuH>();
            DtoDetaPrse = new HashSet<DtoDetaPrse>();
            DtoSumaImpu = new HashSet<DtoSumaImpu>();
        }

        public string CodiImpu { get; set; }
        public string DescImpu { get; set; }
        public decimal? PorcImpu { get; set; }
        public string NombImpu { get; set; }
        public string TipoImpu { get; set; }

        public virtual ICollection<DteDetaPrse> DteDetaPrse { get; set; }
        public virtual ICollection<DteDetaPrseH> DteDetaPrseH { get; set; }
        public virtual ICollection<DteSumaImpu> DteSumaImpu { get; set; }
        public virtual ICollection<DteSumaImpuH> DteSumaImpuH { get; set; }
        public virtual ICollection<DtoDetaPrse> DtoDetaPrse { get; set; }
        public virtual ICollection<DtoSumaImpu> DtoSumaImpu { get; set; }
    }
}
