using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeDetaLibr
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrLibe { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string FoliAnul { get; set; }
        public decimal? TipoServ { get; set; }
        public string FechEmis { get; set; }
        public string FechVenc { get; set; }
        public string PeriDesd { get; set; }
        public string PeriHast { get; set; }
        public decimal? CodiSucu { get; set; }
        public decimal? RuttRece { get; set; }
        public string DigiRece { get; set; }
        public string CodiInte { get; set; }
        public decimal? MontExen { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? TotaPeri { get; set; }
        public decimal? SaldAnte { get; set; }
        public decimal? ValoPaga { get; set; }
        public decimal? MontNeto { get; set; }
        public decimal? TasaVaag { get; set; }
        public decimal? FoliNoti { get; set; }

        public virtual LbeCaraLibr Co { get; set; }
    }
}
