using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteAutoPers
    {
        public string CodiPers { get; set; }
        public string TipoAuto { get; set; }
        public DateTime FeinAuto { get; set; }
        public DateTime? FeteAuto { get; set; }
        public string EstaAuto { get; set; }
        public decimal? DefeAuto { get; set; }
        public decimal CodiEmpr { get; set; }
        public string CodiEmex { get; set; }

        public virtual Personas CodiPersNavigation { get; set; }
    }
}
