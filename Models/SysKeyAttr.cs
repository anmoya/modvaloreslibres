using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysKeyAttr
    {
        public string TableName { get; set; }
        public decimal NumberKey { get; set; }
        public string AttrName { get; set; }
        public decimal? AttrOrder { get; set; }

        public virtual SysKey SysKey { get; set; }
    }
}
