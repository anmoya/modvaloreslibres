using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteArchAdju
    {
        public string CodiEmex { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal PosiAdju { get; set; }
        public string TipoAdju { get; set; }
        public string NmbfAdju { get; set; }

        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
