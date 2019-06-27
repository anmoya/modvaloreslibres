using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtecMessage
    {
        public decimal CorrMsge { get; set; }
        public string NameMsge { get; set; }
        public string TipoMsge { get; set; }
        public string ToknUsed { get; set; }
        public string TmplMsge { get; set; }
    }
}
