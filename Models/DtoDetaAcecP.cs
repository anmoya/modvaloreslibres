using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoDetaAcecP
    {
        public decimal? CodiEmpr { get; set; }
        public decimal CorrDocu { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string CorrAcec { get; set; }
        public string CodiAcec { get; set; }
        public string MnsgErro { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DtoEncaDocuP CorrDocuNavigation { get; set; }
    }
}
