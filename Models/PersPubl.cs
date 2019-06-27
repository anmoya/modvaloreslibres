using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class PersPubl
    {
        public decimal ContRutt { get; set; }
        public string ContDigi { get; set; }
        public string ContRazo { get; set; }
        public string ContCasiSii { get; set; }
        public string ContUrllSii { get; set; }
        public string FechConf { get; set; }
        public string PersPais { get; set; }
        public string FechReso { get; set; }

        public virtual PersPaide PersPaide { get; set; }
    }
}
