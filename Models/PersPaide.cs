using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class PersPaide
    {
        public decimal ContRutt { get; set; }
        public string ContDigi { get; set; }
        public string ContUrllSii { get; set; }

        public virtual PersPubl ContRuttNavigation { get; set; }
    }
}
