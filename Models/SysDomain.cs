using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysDomain
    {
        public SysDomain()
        {
            SysCode = new HashSet<SysCode>();
            SysCodi = new HashSet<SysCodi>();
            SysDomaCult = new HashSet<SysDomaCult>();
        }

        public decimal DomainCode { get; set; }
        public string DomainName { get; set; }
        public decimal? DomainLength { get; set; }
        public string DomainType { get; set; }
        public string DomainShow { get; set; }
        public string DomainClass { get; set; }
        public string DomainLow { get; set; }
        public string DomainHight { get; set; }
        public string DomainView { get; set; }
        public string DomainSclass { get; set; }
        public string DomainQuery { get; set; }
        public string DomainAux { get; set; }
        public string DomainAuxlabel { get; set; }
        public decimal? Mantenedor { get; set; }

        public virtual ICollection<SysCode> SysCode { get; set; }
        public virtual ICollection<SysCodi> SysCodi { get; set; }
        public virtual ICollection<SysDomaCult> SysDomaCult { get; set; }
    }
}
