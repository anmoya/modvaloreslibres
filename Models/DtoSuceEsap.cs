using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoSuceEsap
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrDocu { get; set; }
        public decimal CorrSuce { get; set; }
        public string EstaDocu { get; set; }
        public string CodiEsap { get; set; }
        public string FechEsap { get; set; }
        public string UsuaEsap { get; set; }
        public string RazoEsap { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }
    }
}
