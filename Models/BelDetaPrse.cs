using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelDetaPrse
    {
        public BelDetaPrse()
        {
            BelDetaCodi = new HashSet<BelDetaCodi>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal? IndiExen { get; set; }
        public string NombItem { get; set; }
        public string DescAdic { get; set; }
        public decimal? CantItem { get; set; }
        public string UnidMed { get; set; }
        public decimal? PrecUnic { get; set; }
        public decimal ValoLine { get; set; }
        public decimal? PorcDesc { get; set; }
        public decimal? MontDesc { get; set; }
        public decimal? PorcReca { get; set; }
        public decimal? MontReca { get; set; }
        public string ItemEspe { get; set; }
        public string RuttMand { get; set; }

        public virtual BelEncaDocu BelEncaDocu { get; set; }
        public virtual ICollection<BelDetaCodi> BelDetaCodi { get; set; }
    }
}
