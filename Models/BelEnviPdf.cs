using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelEnviPdf
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal PosicionEmail { get; set; }
        public string EmailEnvi { get; set; }
        public string HacerEnvi { get; set; }
    }
}
