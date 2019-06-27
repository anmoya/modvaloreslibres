using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdDetaDocu
    {
        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal? VigeDocu { get; set; }
        public decimal TipoOper { get; set; }
        public string FechDocu { get; set; }
        public decimal RuttAsoc { get; set; }
        public string DigiAsoc { get; set; }
        public string NombAsoc { get; set; }
        public decimal? MontNeto { get; set; }
        public decimal? TasaVaag { get; set; }
        public decimal? MontVaag { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontModi { get; set; }
        public decimal? TipoRefe { get; set; }
        public decimal? FoliRefe { get; set; }
        public string FechRefe { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdEncaLigd Co { get; set; }
    }
}
