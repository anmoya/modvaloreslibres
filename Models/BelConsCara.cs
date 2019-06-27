using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelConsCara
    {
        public BelConsCara()
        {
            BelConsResu = new HashSet<BelConsResu>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal CorrCons { get; set; }
        public decimal RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public decimal RuttEnvi { get; set; }
        public string DigiEnvi { get; set; }
        public string FechReso { get; set; }
        public decimal NumeResu { get; set; }
        public string FechInic { get; set; }
        public string FechFina { get; set; }
        public decimal? SecuEnvi { get; set; }
        public string FehoEnvi { get; set; }
        public string EstaEnvi { get; set; }
        public decimal? NumeAten { get; set; }
        public decimal? NumeEnvi { get; set; }
        public string MensEnvi { get; set; }
        public string EstaSsii { get; set; }
        public string MensSsii { get; set; }
        public string TmstRpta { get; set; }
        public string ArchResp { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual DteEstaEnvi EstaEnviNavigation { get; set; }
        public virtual ICollection<BelConsResu> BelConsResu { get; set; }
    }
}
