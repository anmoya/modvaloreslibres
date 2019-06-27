using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnSesrRangOper
    {
        public string CodiServ { get; set; }
        public string CodiSrvd { get; set; }
        public decimal DesdSero { get; set; }
        public decimal HastSero { get; set; }
        public decimal PctiSero { get; set; }
        public decimal MiniSero { get; set; }
        public decimal MaxiSero { get; set; }
        public decimal QsizSero { get; set; }

        public virtual DbnServSrvd CodiS { get; set; }
    }
}
