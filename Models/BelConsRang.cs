using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelConsRang
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal CorrCons { get; set; }
        public string TipoRang { get; set; }
        public decimal FoliInic { get; set; }
        public decimal? FoliFina { get; set; }

        public virtual BelConsResu BelConsResu { get; set; }
    }
}
