using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoDetaPrseP
    {
        public DtoDetaPrseP()
        {
            DtoDescItemP = new HashSet<DtoDescItemP>();
            DtoDetaCodiP = new HashSet<DtoDetaCodiP>();
            DtoRecaItemP = new HashSet<DtoRecaItemP>();
            DtoSucaItemP = new HashSet<DtoSucaItemP>();
        }

        public decimal? CodiEmpr { get; set; }
        public decimal CorrDocu { get; set; }
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
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DtoEncaDocuP CorrDocuNavigation { get; set; }
        public virtual ICollection<DtoDescItemP> DtoDescItemP { get; set; }
        public virtual ICollection<DtoDetaCodiP> DtoDetaCodiP { get; set; }
        public virtual ICollection<DtoRecaItemP> DtoRecaItemP { get; set; }
        public virtual ICollection<DtoSucaItemP> DtoSucaItemP { get; set; }
    }
}
