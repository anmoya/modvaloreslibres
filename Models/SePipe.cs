using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SePipe
    {
        public decimal PipeId { get; set; }
        public string PipeStat { get; set; }
        public string PipeCmd { get; set; }
        public DateTime? PipeFechCrea { get; set; }
        public DateTime? PipeFechEjec { get; set; }
        public string PipeCodiUsua { get; set; }
    }
}
