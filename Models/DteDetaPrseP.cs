using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDetaPrseP
    {
        public DteDetaPrseP()
        {
            DteDescItemP = new HashSet<DteDescItemP>();
            DteDetaCodiP = new HashSet<DteDetaCodiP>();
            DteRecaItemP = new HashSet<DteRecaItemP>();
            DteSucaItemP = new HashSet<DteSucaItemP>();
        }

        public decimal CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public string TipoCodi { get; set; }
        public string CodiItem { get; set; }
        public string IndiExen { get; set; }
        public string NombItem { get; set; }
        public string DescItem { get; set; }
        public string CantRefe { get; set; }
        public string UnidRefe { get; set; }
        public string PrecRefe { get; set; }
        public string CantItem { get; set; }
        public string FechElab { get; set; }
        public string FechVepr { get; set; }
        public string UnidMedi { get; set; }
        public string PrecItem { get; set; }
        public string PrecMono { get; set; }
        public string CodiMone { get; set; }
        public string FactConv { get; set; }
        public string DescPorc { get; set; }
        public string DctoItem { get; set; }
        public string RecaPorc { get; set; }
        public string RecaItem { get; set; }
        public string CodiImpu { get; set; }
        public string NetoItem { get; set; }
        public string MnsgErro { get; set; }

        public virtual DteEncaDocuP DteEncaDocuP { get; set; }
        public virtual ICollection<DteDescItemP> DteDescItemP { get; set; }
        public virtual ICollection<DteDetaCodiP> DteDetaCodiP { get; set; }
        public virtual ICollection<DteRecaItemP> DteRecaItemP { get; set; }
        public virtual ICollection<DteSucaItemP> DteSucaItemP { get; set; }
    }
}
