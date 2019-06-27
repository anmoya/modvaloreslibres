using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class Mtod
    {
        public decimal MtodId { get; set; }
        public string MtodStat { get; set; }
        public string MtodFrom { get; set; }
        public string MtodTo { get; set; }
        public string MtodCc { get; set; }
        public string MtodSubject { get; set; }
        public string MtodText { get; set; }
        public DateTime? MtodEnvio { get; set; }
        public decimal? MtodErrno { get; set; }
        public string MtodErrtxt { get; set; }
    }
}
