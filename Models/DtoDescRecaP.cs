using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoDescRecaP
    {
        public decimal? CodiEmpr { get; set; }
        public decimal CorrDocu { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string NumeDere { get; set; }
        public string TipoDere { get; set; }
        public string GlosDere { get; set; }
        public string TipoValo { get; set; }
        public string ValoDere { get; set; }
        public string IndiExen { get; set; }
        public string MnsgErro { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DtoEncaDocuP CorrDocuNavigation { get; set; }
    }
}
