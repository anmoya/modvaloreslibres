using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysDomaCult
    {
        public decimal DomainCode { get; set; }
        public string CodiCult { get; set; }
        public string DomainName { get; set; }

        public virtual SysDomain DomainCodeNavigation { get; set; }
    }
}
