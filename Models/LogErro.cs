using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LogErro
    {
        public decimal CorrLogg { get; set; }
        public string ProcErro { get; set; }
        public string MsajErro { get; set; }
        public string FechErro { get; set; }
        public string HoraErro { get; set; }
        public string BinnErro { get; set; }
        public decimal? CodiEmpr { get; set; }
        public decimal? TipoDocu { get; set; }
        public decimal? FoliDocu { get; set; }
        public string ArchErro { get; set; }
    }
}
