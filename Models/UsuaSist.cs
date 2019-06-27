using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class UsuaSist
    {
        public UsuaSist()
        {
            SysAlus = new HashSet<SysAlus>();
            SysUsfa = new HashSet<SysUsfa>();
            SysUsro = new HashSet<SysUsro>();
            UsuaEmpr = new HashSet<UsuaEmpr>();
        }

        public string CodiUsua { get; set; }
        public string NombUsua { get; set; }
        public string CodiPers { get; set; }
        public string CodiRous { get; set; }
        public decimal? CodiEmpr { get; set; }
        public DateTime? FechUsua { get; set; }
        public string CodiImpr { get; set; }
        public string CodiOfic { get; set; }
        public string CodiCeco { get; set; }
        public decimal? CodiZona { get; set; }
        public string CodiMenu { get; set; }
        public string NiveUsua { get; set; }
        public string NocoUsua { get; set; }
        public string PassUsua { get; set; }
        public string TipoUsua { get; set; }
        public string CodiRamo { get; set; }
        public string FonoUsua { get; set; }
        public string LugaUsua { get; set; }
        public string DigiUsua { get; set; }
        public string CodiDbst { get; set; }
        public DateTime? FeteUsua { get; set; }
        public string MailUsua { get; set; }
        public string CodiEmex { get; set; }
        public string TipoFold { get; set; }
        public string CodiCult { get; set; }
        public string UsuaFilt { get; set; }

        public virtual CentCost Codi { get; set; }
        public virtual Personas CodiPersNavigation { get; set; }
        public virtual ICollection<SysAlus> SysAlus { get; set; }
        public virtual ICollection<SysUsfa> SysUsfa { get; set; }
        public virtual ICollection<SysUsro> SysUsro { get; set; }
        public virtual ICollection<UsuaEmpr> UsuaEmpr { get; set; }
    }
}
