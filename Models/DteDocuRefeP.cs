using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDocuRefeP
    {
        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string NumeRefe { get; set; }
        public string TipoRefe { get; set; }
        public string FoliRefe { get; set; }
        public string RuttOtro { get; set; }
        public string DigiOtro { get; set; }
        public string FechRefe { get; set; }
        public string RazoRefe { get; set; }
        public string CodiRefe { get; set; }
        public string IndiRegl { get; set; }
        public string MnsgErro { get; set; }

        public virtual DteEncaDocuP DteEncaDocuP { get; set; }
    }
}
