using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvDigiDocu
    {
        public LcvDigiDocu()
        {
            LcvDigiImpu = new HashSet<LcvDigiImpu>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string TipoOper { get; set; }
        public decimal RuttAsoc { get; set; }
        public string DigiAsoc { get; set; }
        public decimal TasaImpu { get; set; }
        public decimal? NumeInte { get; set; }
        public decimal? VentServ { get; set; }
        public decimal? IndiSico { get; set; }
        public string FechDocu { get; set; }
        public decimal? CodiSucu { get; set; }
        public string NombAsoc { get; set; }
        public decimal? TipoRefe { get; set; }
        public decimal? FoliRefe { get; set; }
        public decimal? MontExen { get; set; }
        public decimal? MontNeto { get; set; }
        public decimal? MontVaag { get; set; }
        public decimal? MontVafi { get; set; }
        public decimal? MontUsco { get; set; }
        public decimal? MontFupo { get; set; }
        public decimal? MontLe18 { get; set; }
        public decimal? MontSicr { get; set; }
        public decimal? IvagRtto { get; set; }
        public decimal? IvagRtpa { get; set; }
        public decimal? MontCred { get; set; }
        public decimal? MontEnva { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontNret { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? MontPeri { get; set; }
        public decimal? MontPana { get; set; }
        public decimal? MontPain { get; set; }
        public decimal? VaagProp { get; set; }
        public decimal? VaagTerc { get; set; }
        public string VigeDocu { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
        public virtual ICollection<LcvDigiImpu> LcvDigiImpu { get; set; }
    }
}
