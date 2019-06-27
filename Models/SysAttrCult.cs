using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysAttrCult
    {
        public string ObjectName { get; set; }
        public string AttrName { get; set; }
        public string CodiCult { get; set; }
        public string ObjectBrief { get; set; }
        public string ObjectDesc { get; set; }

        public virtual SysAttribute SysAttribute { get; set; }
    }
}
