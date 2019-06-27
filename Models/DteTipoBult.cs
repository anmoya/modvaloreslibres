using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteTipoBult
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal CodiTibu { get; set; }
        public decimal? CantBult { get; set; }
        public string IdenMarc { get; set; }
        public string IdenCont { get; set; }
        public string SelloCont { get; set; }
        public string NombEmis { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
