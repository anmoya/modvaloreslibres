using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteCertPers
    {
        public string CodiPers { get; set; }
        public DateTime FeinCert { get; set; }
        public string CodiOrce { get; set; }
        public DateTime? FeteCert { get; set; }
        public string LlavPubl { get; set; }
        public string LlavPriv { get; set; }
        public string EstaCert { get; set; }
        public string ArchCert { get; set; }
        public string CodiEmex { get; set; }
        public decimal CorrCert { get; set; }
        public string ClobCert { get; set; }

        public virtual DteOrgaCert CodiOrceNavigation { get; set; }
        public virtual Personas CodiPersNavigation { get; set; }
    }
}
