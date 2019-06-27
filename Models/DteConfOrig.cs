using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteConfOrig
    {
        public decimal CodiEmpr { get; set; }
        public string TipoOrig { get; set; }
        public decimal TipoDocu { get; set; }
        public string AsigAuto { get; set; }
        public decimal? PorcRepo { get; set; }
        public decimal? CantFoli { get; set; }

        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
        public virtual DteTipoOrig TipoOrigNavigation { get; set; }
    }
}
