using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeDetaDocu
    {
        public decimal CorrLibe { get; set; }
        public decimal CodiSoli { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal? TipoServ { get; set; }
        public decimal? CodiEmpr { get; set; }
        public decimal? FoliAnul { get; set; }
        public string FechEmis { get; set; }
        public string FechVenc { get; set; }
        public string PeriDesd { get; set; }
        public string PeriHast { get; set; }
        public decimal? CodiSucu { get; set; }
        public decimal? RuttAsoc { get; set; }
        public string DigiAsoc { get; set; }
        public string CodiIncl { get; set; }
        public decimal? MontExen { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? MontPeri { get; set; }
        public decimal? TotaSaan { get; set; }
        public decimal? TotaVapa { get; set; }

        public virtual LbeEncaLibr Co { get; set; }
    }
}
