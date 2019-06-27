using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteOrgaCert
    {
        public DteOrgaCert()
        {
            DteCertPers = new HashSet<DteCertPers>();
        }

        public string CodiOrce { get; set; }
        public string NombOrce { get; set; }
        public decimal? RuttOrce { get; set; }
        public string DigiOrce { get; set; }

        public virtual ICollection<DteCertPers> DteCertPers { get; set; }
    }
}
