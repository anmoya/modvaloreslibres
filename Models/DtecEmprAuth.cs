using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtecEmprAuth
    {
        public decimal CorrEmpr { get; set; }
        public string HoldEmpr { get; set; }
        public decimal RuttEmpr { get; set; }
        public string DigiEmpr { get; set; }
        public string NombEmpr { get; set; }
        public string ClavAcsi { get; set; }
        public string ChngSsii { get; set; }
        public string CertEmpr { get; set; }
        public string ToknEmpr { get; set; }
        public DateTime? ToknTmst { get; set; }
    }
}
