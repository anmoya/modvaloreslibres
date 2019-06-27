using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeSegmTise
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrLibe { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal IndiServ { get; set; }
        public string PeriDeve { get; set; }
        public decimal? TotaDocu { get; set; }
        public decimal? TotaExen { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? MontPeri { get; set; }
        public decimal? SaldAnte { get; set; }
        public decimal? ValoPaga { get; set; }
        public decimal? MontNeto { get; set; }
        public decimal? TasaVaag { get; set; }
        public decimal? TotaVaag { get; set; }

        public virtual LbeResuSegm LbeResuSegm { get; set; }
    }
}
