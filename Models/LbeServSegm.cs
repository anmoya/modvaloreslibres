using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeServSegm
    {
        public decimal TipoDocu { get; set; }
        public decimal CodiSoli { get; set; }
        public decimal CorrLibe { get; set; }
        public decimal CodiServ { get; set; }
        public decimal? TipoServ { get; set; }
        public decimal? CodiEmpr { get; set; }
        public string PeriDeve { get; set; }
        public decimal? TotaDocu { get; set; }
        public decimal? TotaExen { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? TotaNofa { get; set; }
        public decimal? TotaPeri { get; set; }
        public decimal? TotaSaan { get; set; }
        public decimal? TotaVapa { get; set; }

        public virtual LbeTotaSegm LbeTotaSegm { get; set; }
    }
}
