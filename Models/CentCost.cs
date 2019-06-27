using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class CentCost
    {
        public CentCost()
        {
            BelUnidCont = new HashSet<BelUnidCont>();
            DteRangFoli = new HashSet<DteRangFoli>();
            FoliAnul = new HashSet<FoliAnul>();
            OficEmpr = new HashSet<OficEmpr>();
            Personas = new HashSet<Personas>();
            UsuaExte = new HashSet<UsuaExte>();
            UsuaSist = new HashSet<UsuaSist>();
        }

        public string CodiCeco { get; set; }
        public string NombCeco { get; set; }
        public string CodiCeco1 { get; set; }
        public string TipoCeco { get; set; }
        public decimal CodiEmpr { get; set; }
        public decimal? NumeCeco { get; set; }
        public string ResuCeco { get; set; }
        public string ResuCeco1 { get; set; }
        public string FlagRamo { get; set; }
        public decimal? LeveCeco { get; set; }
        public string OperCuco { get; set; }
        public decimal? CodiZona { get; set; }
        public string CodiOfic { get; set; }
        public string ActiCeco { get; set; }
        public DateTime? FeinCeco { get; set; }
        public DateTime? FeteCeco { get; set; }
        public string CodiPers { get; set; }
        public decimal? NumeCeco1 { get; set; }
        public string CodiCiud { get; set; }
        public string CodiUbic { get; set; }
        public string CodiExen { get; set; }
        public string TiarCeco { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual Personas CodiPersNavigation { get; set; }
        public virtual ICollection<BelUnidCont> BelUnidCont { get; set; }
        public virtual ICollection<DteRangFoli> DteRangFoli { get; set; }
        public virtual ICollection<FoliAnul> FoliAnul { get; set; }
        public virtual ICollection<OficEmpr> OficEmpr { get; set; }
        public virtual ICollection<Personas> Personas { get; set; }
        public virtual ICollection<UsuaExte> UsuaExte { get; set; }
        public virtual ICollection<UsuaSist> UsuaSist { get; set; }
    }
}
