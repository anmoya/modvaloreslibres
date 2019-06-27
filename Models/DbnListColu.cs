using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnListColu
    {
        public string CodiRepo { get; set; }
        public string CodiColu { get; set; }
        public string NombColu { get; set; }
        public string DescColu { get; set; }
        public string CodiResx { get; set; }
        public string ClasCss { get; set; }
        public string TipoColu { get; set; }
        public string AnchColu { get; set; }
        public string AlinColu { get; set; }
        public string FormColu { get; set; }
        public string IndiVisi { get; set; }
        public string ImagColu { get; set; }
        public string JqryColu { get; set; }
        public int? OrdeColu { get; set; }
        public string TipoBusq { get; set; }
        public string IndiBusq { get; set; }
        public string ColuBusq { get; set; }
        public string VerdBusq { get; set; }
        public string FalsBusq { get; set; }
        public string CodiLiva { get; set; }

        public virtual DbnListRepo CodiRepoNavigation { get; set; }
    }
}
