using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelAsigFoli
    {
        public decimal CorrAsig { get; set; }
        public decimal CodiEmpr { get; set; }
        public string CodiCeco { get; set; }
        public decimal CorrRafo { get; set; }
        public string CodiUnid { get; set; }
        public string EstaAsig { get; set; }
        public decimal FoliDesd { get; set; }
        public decimal FoliHast { get; set; }
        public DateTime FechAsig { get; set; }
        public decimal? CantReen { get; set; }
        public decimal? UltiUsad { get; set; }
        public string TipoOrig { get; set; }
        public string StrrAsig { get; set; }
        public string StrrCaff { get; set; }

        public virtual BelUnidCont BelUnidCont { get; set; }
        public virtual DteRangFoli CorrRafoNavigation { get; set; }
    }
}
