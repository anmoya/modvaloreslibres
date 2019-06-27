using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbePeriTise
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrLibe { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal IndiServ { get; set; }
        public string PeriDeve { get; set; }
        public decimal? TotaDocu { get; set; }
        public decimal? TotaExen { get; set; }
        public decimal? TotaNeto { get; set; }
        public decimal? TasaIvaa { get; set; }
        public decimal? MontIvaa { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? TotaPeri { get; set; }
        public decimal? SaldAnte { get; set; }
        public decimal? ValoPaga { get; set; }

        public virtual LbeResuPeri LbeResuPeri { get; set; }
    }
}
