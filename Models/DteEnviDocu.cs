using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteEnviDocu
    {
        public DteEnviDocu()
        {
            DteEncaDocuCorrEnvi1Navigation = new HashSet<DteEncaDocu>();
            DteEncaDocuCorrEnviNavigation = new HashSet<DteEncaDocu>();
            DteTidoEnvi = new HashSet<DteTidoEnvi>();
        }

        public decimal? CodiEmpr { get; set; }
        public decimal CorrEnvi { get; set; }
        public decimal? RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public decimal? RuttEnvi { get; set; }
        public string DigiEnvi { get; set; }
        public string FehoEnvi { get; set; }
        public string VersEnvi { get; set; }
        public string EstaEnvi { get; set; }
        public string MensEnvi { get; set; }
        public decimal? RuttRece { get; set; }
        public string DigiRece { get; set; }
        public decimal? NumeReso { get; set; }
        public string FechReso { get; set; }
        public string CodiPers { get; set; }
        public decimal? RuttPers { get; set; }
        public string DigiPers { get; set; }
        public decimal? PosiEnvi { get; set; }
        public string BlocEnvi { get; set; }
        public string NombArch { get; set; }
        public decimal? NumeAten { get; set; }
        public decimal? NumeEnvi { get; set; }
        public string DireArch { get; set; }
        public string ColaProc { get; set; }
        public string BoleElec { get; set; }
        public string FechUpld { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual DteEstaEnvi EstaEnviNavigation { get; set; }
        public virtual ICollection<DteEncaDocu> DteEncaDocuCorrEnvi1Navigation { get; set; }
        public virtual ICollection<DteEncaDocu> DteEncaDocuCorrEnviNavigation { get; set; }
        public virtual ICollection<DteTidoEnvi> DteTidoEnvi { get; set; }
    }
}
