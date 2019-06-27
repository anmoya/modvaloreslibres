using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnMoniStat
    {
        public string CodiSrvd { get; set; }
        public string CodiServ { get; set; }
        public decimal MoprPid { get; set; }
        public decimal MostPeriOper { get; set; }
        public decimal MostSumaOper { get; set; }
        public decimal MostSumaSlee { get; set; }
        public decimal MostSumaErro { get; set; }
        public decimal MostNumeInst { get; set; }
    }
}
