using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdDetaDocuP
    {
        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public string FoliDocu { get; set; }
        public string VigeDocu { get; set; }
        public string TipoOper { get; set; }
        public string FechDocu { get; set; }
        public string RuttAsoc { get; set; }
        public string DigiAsoc { get; set; }
        public string NombAsoc { get; set; }
        public string MontNeto { get; set; }
        public string TasaVaag { get; set; }
        public string MontVaag { get; set; }
        public string MontTota { get; set; }
        public string MontModi { get; set; }
        public string TipoRefe { get; set; }
        public string FoliRefe { get; set; }
        public string FechRefe { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdEncaLigdP Co { get; set; }
    }
}
