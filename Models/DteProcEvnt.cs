using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteProcEvnt
    {
        public decimal CorrEvnt { get; set; }
        public string EstaEvnt { get; set; }
        public DateTime FechEvnt { get; set; }
        public string CodiEmex { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal CorrDocu { get; set; }
        public decimal RuttRece { get; set; }
        public string DigiRece { get; set; }
        public decimal RuttEmis { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string EvntSii { get; set; }
        public DateTime FechProcEvnt { get; set; }
        public decimal ContProcEvnt { get; set; }
        public string MensErroEvnt { get; set; }
        public decimal? CodiRtrn { get; set; }
        public string RespSii { get; set; }
        public string CurlPara { get; set; }
        public string DigiEmis { get; set; }
    }
}
