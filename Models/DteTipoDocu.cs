using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteTipoDocu
    {
        public DteTipoDocu()
        {
            BelConsResu = new HashSet<BelConsResu>();
            BelEncaDocu = new HashSet<BelEncaDocu>();
            BelFoliAnul = new HashSet<BelFoliAnul>();
            DteCesiDocu = new HashSet<DteCesiDocu>();
            DteConfOrig = new HashSet<DteConfOrig>();
            DteDelCesion = new HashSet<DteDelCesion>();
            DteEncaDocu = new HashSet<DteEncaDocu>();
            DteEncaDocuH = new HashSet<DteEncaDocuH>();
            DteTidoEnvi = new HashSet<DteTidoEnvi>();
            DteTidoEnviH = new HashSet<DteTidoEnviH>();
            DtoEncaDocu = new HashSet<DtoEncaDocu>();
            DtoTidoRece = new HashSet<DtoTidoRece>();
            LcvDigiDocu = new HashSet<LcvDigiDocu>();
        }

        public decimal TipoDocu { get; set; }
        public string DescTido { get; set; }
        public string DocuElec { get; set; }
        public decimal? NumeImpr { get; set; }
        public decimal? OrdeEnvi { get; set; }
        public string IndiDnte { get; set; }
        public string DocuRefe { get; set; }
        public string BoleElec { get; set; }
        public decimal? NumeImme { get; set; }
        public string IndiCesi { get; set; }
        public string IndiReci { get; set; }
        public string RepoAuto { get; set; }
        public string ClasDocu { get; set; }
        public string TipoComo { get; set; }
        public string EstaDocu { get; set; }
        public string TramImpr { get; set; }
        public string TramImme { get; set; }
        public string IndiDigi { get; set; }
        public string IndiLibr { get; set; }
        public string CodiEmex { get; set; }

        public virtual ICollection<BelConsResu> BelConsResu { get; set; }
        public virtual ICollection<BelEncaDocu> BelEncaDocu { get; set; }
        public virtual ICollection<BelFoliAnul> BelFoliAnul { get; set; }
        public virtual ICollection<DteCesiDocu> DteCesiDocu { get; set; }
        public virtual ICollection<DteConfOrig> DteConfOrig { get; set; }
        public virtual ICollection<DteDelCesion> DteDelCesion { get; set; }
        public virtual ICollection<DteEncaDocu> DteEncaDocu { get; set; }
        public virtual ICollection<DteEncaDocuH> DteEncaDocuH { get; set; }
        public virtual ICollection<DteTidoEnvi> DteTidoEnvi { get; set; }
        public virtual ICollection<DteTidoEnviH> DteTidoEnviH { get; set; }
        public virtual ICollection<DtoEncaDocu> DtoEncaDocu { get; set; }
        public virtual ICollection<DtoTidoRece> DtoTidoRece { get; set; }
        public virtual ICollection<LcvDigiDocu> LcvDigiDocu { get; set; }
    }
}
