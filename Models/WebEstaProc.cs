using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class WebEstaProc
    {
        public decimal CorrProc { get; set; }
        public decimal NumeProc { get; set; }
        public string NombProc { get; set; }
        public string DescProc { get; set; }
        public string FechInic { get; set; }
        public string FechTerm { get; set; }
        public string BorrMens { get; set; }
        public string CodiUsua { get; set; }
    }
}
