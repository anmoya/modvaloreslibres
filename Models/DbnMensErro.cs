using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnMensErro
    {
        public int CorrErro { get; set; }
        public int CodiErro { get; set; }
        public string MensErro { get; set; }
        public string LineErro { get; set; }
        public string PrccErro { get; set; }
        public int CorrSess { get; set; }
    }
}
