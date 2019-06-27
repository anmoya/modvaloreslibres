using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteRangFoli
    {
        public DteRangFoli()
        {
            BelAsigFoli = new HashSet<BelAsigFoli>();
            BelEncaDocu = new HashSet<BelEncaDocu>();
            DteEncaDocu = new HashSet<DteEncaDocu>();
            DteEncaDocuH = new HashSet<DteEncaDocuH>();
        }

        public decimal CorrRafo { get; set; }
        public decimal? CodiEmpr { get; set; }
        public decimal? TipoDora { get; set; }
        public decimal? FoliDesd { get; set; }
        public decimal? FoliHast { get; set; }
        public DateTime? FechSoli { get; set; }
        public DateTime? FechAuto { get; set; }
        public string CodiCeco { get; set; }
        public string EstaRafo { get; set; }
        public string LlavPrivRafo { get; set; }
        public string LlavPublRafo { get; set; }
        public decimal? UltiFoli { get; set; }
        public decimal? RuttEmpr { get; set; }
        public string DigiEmpr { get; set; }
        public string LlavPucoModu { get; set; }
        public string LlavPucoExpo { get; set; }
        public string LlavPusiIden { get; set; }
        public string CodiOfic { get; set; }
        public string CodiPers { get; set; }
        public string FirmSii { get; set; }
        public string ArchCaf { get; set; }
        public string RazoSoci { get; set; }
        public decimal? UltiAsig { get; set; }
        public decimal? CafIngr { get; set; }
        public string CodiEmex { get; set; }

        public virtual CentCost Codi { get; set; }
        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual OficEmpr CodiNavigation { get; set; }
        public virtual Personas CodiPersNavigation { get; set; }
        public virtual ICollection<BelAsigFoli> BelAsigFoli { get; set; }
        public virtual ICollection<BelEncaDocu> BelEncaDocu { get; set; }
        public virtual ICollection<DteEncaDocu> DteEncaDocu { get; set; }
        public virtual ICollection<DteEncaDocuH> DteEncaDocuH { get; set; }
    }
}
