using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteSucaItem
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrSuca { get; set; }
        public string CodiSuca { get; set; }
        public decimal? SucaDist { get; set; }
        public string MnsgErro { get; set; }
        public string TipoSuca { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteDetaPrse DteDetaPrse { get; set; }
    }
}
