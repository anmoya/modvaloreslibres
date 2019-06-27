using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysMessCult
    {
        public decimal CodiMess { get; set; }
        public string CodiCult { get; set; }
        public string DescMess { get; set; }
        public string TipoMess { get; set; }

        public virtual SysMessage CodiMessNavigation { get; set; }
    }
}
