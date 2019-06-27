using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysKey
    {
        public SysKey()
        {
            SysKeyAttr = new HashSet<SysKeyAttr>();
        }

        public string TableName { get; set; }
        public string TypeKey { get; set; }
        public decimal NumberKey { get; set; }
        public string GenKey { get; set; }
        public string UniqueKey { get; set; }
        public string KeyDesc { get; set; }
        public string KeyDepe { get; set; }

        public virtual ICollection<SysKeyAttr> SysKeyAttr { get; set; }
    }
}
