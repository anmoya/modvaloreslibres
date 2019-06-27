using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class QseDocuServ
    {
        public decimal CodiDopr { get; set; }
        public string CodiServ { get; set; }
        public string CodiEmex { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string EstaProc { get; set; }
        public DateTime TimeProc { get; set; }
        public decimal? CantProc { get; set; }
        public string CodiDocu { get; set; }
        public decimal? CorrRefe { get; set; }
        public string CodiSrvd { get; set; }
        public string TablOrig { get; set; }
        public string ValoPk1 { get; set; }
        public string ValoPk2 { get; set; }
        public string ValoPk3 { get; set; }
        public string ValoPk4 { get; set; }
        public string ValoPk5 { get; set; }
        public string TablEsta { get; set; }
        public string UltiErro { get; set; }
        public string FlagDocu { get; set; }

        public virtual EmprExte CodiEmexNavigation { get; set; }
    }
}
