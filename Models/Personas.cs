using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class Personas
    {
        public Personas()
        {
            CaraPeem = new HashSet<CaraPeem>();
            CaraPers = new HashSet<CaraPers>();
            CentCost = new HashSet<CentCost>();
            DteAutoPers = new HashSet<DteAutoPers>();
            DteCertPers = new HashSet<DteCertPers>();
            DteRangFoli = new HashSet<DteRangFoli>();
            Empr = new HashSet<Empr>();
            InverseCodiPers1Navigation = new HashSet<Personas>();
            ParaPers = new HashSet<ParaPers>();
            UsemExte = new HashSet<UsemExte>();
            UsuaExte = new HashSet<UsuaExte>();
        }

        public string CodiPers { get; set; }
        public string NombPers { get; set; }
        public decimal? RuttPers { get; set; }
        public string DgtoPers { get; set; }
        public string DirePers { get; set; }
        public string CodiComu { get; set; }
        public string FonoPers { get; set; }
        public string CliePers { get; set; }
        public string ProvPers { get; set; }
        public string CompPers { get; set; }
        public string EmplPers { get; set; }
        public string CodiPers1 { get; set; }
        public string PersSele { get; set; }
        public string EmprPers { get; set; }
        public string PrefPers { get; set; }
        public string FuncPers { get; set; }
        public string CodiRamo { get; set; }
        public DateTime? FechPers { get; set; }
        public string ComePers { get; set; }
        public string CodiPais { get; set; }
        public string CodiCeco { get; set; }
        public decimal? CodiEmpr { get; set; }
        public string CodiMail { get; set; }
        public string NfanPers { get; set; }
        public string CodiEciv { get; set; }
        public string CodiProf { get; set; }
        public string SexoPers { get; set; }
        public string OrigPers { get; set; }
        public string AcciPers { get; set; }
        public string TipoDesc { get; set; }
        public string CodiMail1 { get; set; }
        public string CodiMail2 { get; set; }
        public string CodiMail3 { get; set; }
        public string CodiMail4 { get; set; }
        public string ModiDocu { get; set; }
        public string AutoCesi { get; set; }
        public string AsunFactPers { get; set; }
        public string TextFactPers { get; set; }
        public string CodiEmex { get; set; }

        public virtual CentCost Codi { get; set; }
        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual Personas CodiPers1Navigation { get; set; }
        public virtual UsuaSist UsuaSist { get; set; }
        public virtual ICollection<CaraPeem> CaraPeem { get; set; }
        public virtual ICollection<CaraPers> CaraPers { get; set; }
        public virtual ICollection<CentCost> CentCost { get; set; }
        public virtual ICollection<DteAutoPers> DteAutoPers { get; set; }
        public virtual ICollection<DteCertPers> DteCertPers { get; set; }
        public virtual ICollection<DteRangFoli> DteRangFoli { get; set; }
        public virtual ICollection<Empr> Empr { get; set; }
        public virtual ICollection<Personas> InverseCodiPers1Navigation { get; set; }
        public virtual ICollection<ParaPers> ParaPers { get; set; }
        public virtual ICollection<UsemExte> UsemExte { get; set; }
        public virtual ICollection<UsuaExte> UsuaExte { get; set; }
    }
}
