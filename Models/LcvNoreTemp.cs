using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvNoreTemp
    {
        public string TipoOper { get; set; }
        public string TipoLibr { get; set; }
        public string RuttAsoc { get; set; }
        public string PeriTrib { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal RuttCont { get; set; }
        public decimal CodiNore { get; set; }
        public decimal MontNore { get; set; }

        public virtual LcvDetaTemp LcvDetaTemp { get; set; }
    }
}
