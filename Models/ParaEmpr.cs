using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class ParaEmpr
    {
        public decimal CodiEmpr { get; set; }
        public string CodiPaem { get; set; }
        public string TipoComo { get; set; }
        public string DescPaem { get; set; }
        public string ValoPaem { get; set; }
        public string ObliPaem { get; set; }
        public string CodiEmex { get; set; }
    }
}
