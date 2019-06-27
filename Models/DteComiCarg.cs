using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteComiCarg
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeCoca { get; set; }
        public string TipoCoca { get; set; }
        public string GlosCoca { get; set; }
        public decimal? TasaCoca { get; set; }
        public decimal? ValoNetoCoca { get; set; }
        public decimal? ValoExenCoca { get; set; }
        public decimal? ValoIvaCoca { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
