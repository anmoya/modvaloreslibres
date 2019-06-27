using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelInfoTick
    {
        public decimal CodiEmpr { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliTick { get; set; }
        public string FechTick { get; set; }
        public string NombEven { get; set; }
        public string TipoTick { get; set; }
        public string CodiEven { get; set; }
        public string FechEven { get; set; }
        public string LugaEven { get; set; }
        public string UbicEven { get; set; }
        public string FilaUbic { get; set; }
        public string AsieUbic { get; set; }

        public virtual BelEncaDocu BelEncaDocu { get; set; }
    }
}
