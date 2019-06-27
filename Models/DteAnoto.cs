using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteAnoto
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string NumeTram { get; set; }
        public string LugaRece { get; set; }
        public string FechRece { get; set; }
        public string IndiAcep { get; set; }
        public string IndiRepa { get; set; }
        public DateTime? FechTram { get; set; }
        public string EstaTram { get; set; }
    }
}
