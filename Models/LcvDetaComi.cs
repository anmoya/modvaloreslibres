using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvDetaComi
    {
        public decimal CodiEmpr { get; set; }
        public decimal CorrLicv { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal RuttAsoc { get; set; }
        public decimal CodiOper { get; set; }
        public string RutEmis { get; set; }
        public decimal ValoNeto { get; set; }
        public decimal ValoExen { get; set; }
        public decimal ValoIva { get; set; }
    }
}
