using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysCodi
    {
        public string Code { get; set; }
        public string CodeDesc { get; set; }
        public decimal DomainCode { get; set; }
        public string CodeAux { get; set; }
        public string CodeDele { get; set; }

        public virtual SysDomain DomainCodeNavigation { get; set; }
    }
}
