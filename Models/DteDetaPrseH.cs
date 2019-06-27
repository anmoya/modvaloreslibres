using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDetaPrseH
    {
        public DteDetaPrseH()
        {
            DteDescItemH = new HashSet<DteDescItemH>();
            DteDetaCodiH = new HashSet<DteDetaCodiH>();
            DteRecaItemH = new HashSet<DteRecaItemH>();
            DteSucaItemH = new HashSet<DteSucaItemH>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public string CodiImpu { get; set; }
        public string TipoCodi { get; set; }
        public string CodiItem { get; set; }
        public decimal? IndiExen { get; set; }
        public string NombItem { get; set; }
        public string DescItem { get; set; }
        public decimal? CantItem { get; set; }
        public decimal? CantRefe { get; set; }
        public string UnidRefe { get; set; }
        public decimal? PrecRefe { get; set; }
        public string UnidMedi { get; set; }
        public decimal? PrecItem { get; set; }
        public decimal? PrecMono { get; set; }
        public string CodiMone { get; set; }
        public decimal? FactConv { get; set; }
        public decimal? DctoItem { get; set; }
        public decimal? RecaItem { get; set; }
        public decimal? NetoItem { get; set; }
        public decimal? DescPorc { get; set; }
        public decimal? RecaPorc { get; set; }
        public string FechElab { get; set; }
        public string FechVepr { get; set; }
        public string MnsgErro { get; set; }

        public virtual DteTipoImpu CodiImpuNavigation { get; set; }
        public virtual DteEncaDocuH DteEncaDocuH { get; set; }
        public virtual ICollection<DteDescItemH> DteDescItemH { get; set; }
        public virtual ICollection<DteDetaCodiH> DteDetaCodiH { get; set; }
        public virtual ICollection<DteRecaItemH> DteRecaItemH { get; set; }
        public virtual ICollection<DteSucaItemH> DteSucaItemH { get; set; }
    }
}
