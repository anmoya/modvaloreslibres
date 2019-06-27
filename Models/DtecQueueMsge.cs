using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtecQueueMsge
    {
        public decimal CorrQmsg { get; set; }
        public string NameMsge { get; set; }
        public string NameAddr { get; set; }
        public decimal RuttEmpr { get; set; }
        public string DigiEmpr { get; set; }
        public string ApplName { get; set; }
        public string CurlPara { get; set; }
        public string EstaQmsg { get; set; }
        public DateTime TmstRegi { get; set; }
        public DateTime TmstProc { get; set; }
        public DateTime? TmstResp { get; set; }
        public decimal? IdenDocu { get; set; }
        public decimal? IdenEvnt { get; set; }
        public string RespQmsg { get; set; }
    }
}
