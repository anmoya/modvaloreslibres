using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoSucaItem
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrSuca { get; set; }
        public string CodiSuca { get; set; }
        public decimal? SucaDist { get; set; }
        public string MnsgErro { get; set; }

        public virtual DtoDetaPrse DtoDetaPrse { get; set; }
    }
}
