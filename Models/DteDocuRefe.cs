using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDocuRefe
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeRefe { get; set; }
        public string TipoRefe { get; set; }
        public string FoliRefe { get; set; }
        public decimal? RuttOtro { get; set; }
        public string DigiOtro { get; set; }
        public string FechRefe { get; set; }
        public string RazoRefe { get; set; }
        public string CodiRefe { get; set; }
        public decimal? IndiRegl { get; set; }
        public string MnsgErro { get; set; }
        public string FoliClie { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
