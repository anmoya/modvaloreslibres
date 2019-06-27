using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteDetaPrse
    {
        public DteDetaPrse()
        {
            DteDescItem = new HashSet<DteDescItem>();
            DteDetaCodi = new HashSet<DteDetaCodi>();
            DteRecaItem = new HashSet<DteRecaItem>();
            DteSucaItem = new HashSet<DteSucaItem>();
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
        public decimal? DescMone { get; set; }
        public decimal? RecaMone { get; set; }
        public decimal? ValoMone { get; set; }
        public string IndiAgen { get; set; }
        public decimal? BaseFaen { get; set; }
        public decimal? MargComer { get; set; }
        public decimal? PrneCofi { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteTipoImpu CodiImpuNavigation { get; set; }
        public virtual DteEncaDocu DteEncaDocu { get; set; }
        public virtual ICollection<DteDescItem> DteDescItem { get; set; }
        public virtual ICollection<DteDetaCodi> DteDetaCodi { get; set; }
        public virtual ICollection<DteRecaItem> DteRecaItem { get; set; }
        public virtual ICollection<DteSucaItem> DteSucaItem { get; set; }
    }
}
