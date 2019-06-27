using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelEnviDocu
    {
        public BelEnviDocu()
        {
            BelEncaDocu = new HashSet<BelEncaDocu>();
            BelTidoEnvi = new HashSet<BelTidoEnvi>();
        }

        public decimal CorrEnvi { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public decimal RuttEnvi { get; set; }
        public string DigiEnvi { get; set; }
        public string FehoEnvi { get; set; }
        public string VersEnvi { get; set; }
        public string EstaEnvi { get; set; }
        public string MensEnvi { get; set; }
        public decimal RuttRece { get; set; }
        public string DigiRece { get; set; }
        public decimal NumeReso { get; set; }
        public string FechReso { get; set; }
        public string NombArch { get; set; }
        public decimal? NumeAten { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual ICollection<BelEncaDocu> BelEncaDocu { get; set; }
        public virtual ICollection<BelTidoEnvi> BelTidoEnvi { get; set; }
    }
}
