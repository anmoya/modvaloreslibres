using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvDetaDocu
    {
        public LcvDetaDocu()
        {
            LcvTotaDocu = new HashSet<LcvTotaDocu>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal CorrLicv { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal RuttAsoc { get; set; }
        public string DigiAsoc { get; set; }
        public string VigeDocu { get; set; }
        public decimal? CodiOper { get; set; }
        public decimal? TipoImpu { get; set; }
        public decimal? TasaImpu { get; set; }
        public string NumeInte { get; set; }
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
        public decimal? MontFupl { get; set; }
        public decimal? MontLe18 { get; set; }
        public decimal? MontSicr { get; set; }
        public decimal? IvaRtto { get; set; }
        public decimal? IvaRtpa { get; set; }
        public decimal? MontCred { get; set; }
        public decimal? MontEnva { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontNret { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? MontPeri { get; set; }
        public decimal? MontPana { get; set; }
        public decimal? MontPain { get; set; }
        public decimal? MontTapu { get; set; }
        public decimal? MontTaci { get; set; }
        public decimal? MontTael { get; set; }
        public decimal? MontVehi { get; set; }
        public string CodiEmex { get; set; }
        public decimal? EmisDocu { get; set; }
        public decimal? MontFijo { get; set; }
        public decimal? VaagProp { get; set; }
        public decimal? VaagTerc { get; set; }
        public decimal? EstaDocu { get; set; }

        public virtual ICollection<LcvTotaDocu> LcvTotaDocu { get; set; }
    }
}
