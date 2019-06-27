using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnListBoto
    {
        public string CodiRepo { get; set; }
        public string CodiBoto { get; set; }
        public string NombBoto { get; set; }
        public string DescBoto { get; set; }
        public string TipoBoto { get; set; }
        public string CodiResx { get; set; }
        public string ClasCss { get; set; }
        public string PageBoto { get; set; }
        public string ProcBoto { get; set; }
        public string CodiPar1 { get; set; }
        public string CodiPar2 { get; set; }
        public string CodiPar3 { get; set; }
        public string CodiPar4 { get; set; }
        public string CodiPar5 { get; set; }
        public string ImagBoto { get; set; }
        public int? OrdeBoto { get; set; }
        public string IndiVisi { get; set; }
        public string ModoBoto { get; set; }
        public string ListDeta { get; set; }

        public virtual DbnListRepo CodiRepoNavigation { get; set; }
    }
}
