using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteCesiAuto
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrCesi { get; set; }
        public decimal NumeAuto { get; set; }
        public decimal? RuttAuto { get; set; }
        public string DigiAuto { get; set; }
        public string NombAuto { get; set; }
        public string FirmAuto { get; set; }

        public virtual DteCesiDocu Co { get; set; }
    }
}
