using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class Version
    {
        public string Componente { get; set; }
        public string Version1 { get; set; }
        public DateTime? FechaEjecucion { get; set; }
        public string ResponsableEjecucion { get; set; }
        public string ObservacionEjecucion { get; set; }
    }
}
