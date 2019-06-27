using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoReceDocu
    {
        public DtoReceDocu()
        {
            DtoEncaDocu = new HashSet<DtoEncaDocu>();
            DtoEncaDocuP = new HashSet<DtoEncaDocuP>();
            DtoTidoRece = new HashSet<DtoTidoRece>();
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
        public decimal? PosiEnvi { get; set; }
        public string BlocEnvi { get; set; }
        public string NombArch { get; set; }
        public string IndeEnvi { get; set; }
        public string FirmEnvi { get; set; }
        public string FechRece { get; set; }
        public string DigiValu { get; set; }
        public string DireArch { get; set; }
        public string NombOrig { get; set; }
        public string CodiServ { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEstaEnvi EstaEnviNavigation { get; set; }
        public virtual ICollection<DtoEncaDocu> DtoEncaDocu { get; set; }
        public virtual ICollection<DtoEncaDocuP> DtoEncaDocuP { get; set; }
        public virtual ICollection<DtoTidoRece> DtoTidoRece { get; set; }
    }
}
