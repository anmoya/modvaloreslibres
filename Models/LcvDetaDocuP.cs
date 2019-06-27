using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LcvDetaDocuP
    {
        public LcvDetaDocuP()
        {
            LcvTotaDocuP = new HashSet<LcvTotaDocuP>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal CorrLicv { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string RuttAsoc { get; set; }
        public string DigiAsoc { get; set; }
        public string VigeDocu { get; set; }
        public string CodiOper { get; set; }
        public string TipoImpu { get; set; }
        public string TasaImpu { get; set; }
        public string NumeInte { get; set; }
        public string VentServ { get; set; }
        public string IndiSico { get; set; }
        public string FechDocu { get; set; }
        public string CodiSucu { get; set; }
        public string NombAsoc { get; set; }
        public string TipoRefe { get; set; }
        public string FoliRefe { get; set; }
        public string MontExen { get; set; }
        public string MontNeto { get; set; }
        public string MontVaag { get; set; }
        public string MontVafi { get; set; }
        public string MontUsco { get; set; }
        public string MontFupl { get; set; }
        public string MontLe18 { get; set; }
        public string MontSicr { get; set; }
        public string IvaRtto { get; set; }
        public string IvaRtpa { get; set; }
        public string MontCred { get; set; }
        public string MontEnva { get; set; }
        public string MontTota { get; set; }
        public string MontNret { get; set; }
        public string MontNofa { get; set; }
        public string MontPeri { get; set; }
        public string MontPana { get; set; }
        public string MontPain { get; set; }
        public string MontTapu { get; set; }
        public string MontTaci { get; set; }
        public string MontTael { get; set; }
        public string MontVehi { get; set; }
        public string CodiEmex { get; set; }
        public string EmisDocu { get; set; }
        public string MontFijo { get; set; }
        public string VaagProp { get; set; }
        public string VaagTerc { get; set; }

        public virtual ICollection<LcvTotaDocuP> LcvTotaDocuP { get; set; }
    }
}
