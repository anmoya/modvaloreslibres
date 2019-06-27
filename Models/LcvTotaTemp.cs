using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvTotaTemp
    {
        public string TipoOper { get; set; }
        public string TipoLibr { get; set; }
        public string RuttAsoc { get; set; }
        public string PeriTrib { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal RuttCont { get; set; }
        public string CodiImpu { get; set; }
        public decimal? TasaImpu { get; set; }
        public decimal? MontImpu { get; set; }

        public virtual LcvDetaTemp LcvDetaTemp { get; set; }
    }
}
