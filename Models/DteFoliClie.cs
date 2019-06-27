using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteFoliClie
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string FoliClie { get; set; }
        public decimal EstaTras { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }
    }
}
