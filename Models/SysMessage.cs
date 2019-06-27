using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysMessage
    {
        public SysMessage()
        {
            SysMessCult = new HashSet<SysMessCult>();
        }

        public decimal CodiMess { get; set; }
        public string CodiModu { get; set; }
        public string DescMess { get; set; }
        public string TipoMess { get; set; }

        public virtual ICollection<SysMessCult> SysMessCult { get; set; }
    }
}
