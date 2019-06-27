using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysObjeCult
    {
        public string ObjectName { get; set; }
        public string CodiCult { get; set; }
        public string ObjectBrief { get; set; }
        public string ObjectDesc { get; set; }
        public string ObjectSingle { get; set; }

        public virtual SysObject ObjectNameNavigation { get; set; }
    }
}
