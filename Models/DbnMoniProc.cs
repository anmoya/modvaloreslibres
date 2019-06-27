using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnMoniProc
    {
        public string ServServ { get; set; }
        public string CodiServ { get; set; }
        public decimal MoprPid { get; set; }
        public string MoprInicPk { get; set; }
        public DateTime? MoprInicOper { get; set; }
        public decimal? MoprNumeOper { get; set; }
        public decimal? MoprNumeSlee { get; set; }
        public decimal? MoprNumeErro { get; set; }
        public string MoprEstaInst { get; set; }
        public DateTime? MoprFechRepo { get; set; }
        public string MoprSemaEsta { get; set; }

        public virtual DbnServSrvd DbnServSrvd { get; set; }
    }
}
