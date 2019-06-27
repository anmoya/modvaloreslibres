using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteAcciDocu
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string CodiAced { get; set; }
        public decimal? NuimSoli { get; set; }
        public decimal? NuimTerm { get; set; }
        public string LogoPubl { get; set; }
        public string PlanDocu { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
