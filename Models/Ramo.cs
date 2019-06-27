using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class Ramo
    {
        public string CodiRamo { get; set; }
        public string DescRamo { get; set; }
        public string CodiRamoSup { get; set; }
        public decimal CodiEmpr { get; set; }
        public string NombRamo { get; set; }
        public string CodiCeco { get; set; }
        public string IndiClie { get; set; }
        public string IndiProv { get; set; }
        public string IndiEmpl { get; set; }
        public string OrdeRamo { get; set; }
        public string IndiEmpr { get; set; }
        public decimal? OrdeGefi { get; set; }
        public string CodiSii { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
    }
}
