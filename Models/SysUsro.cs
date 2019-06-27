using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysUsro
    {
        public string CodiRous { get; set; }
        public string CodiUsua { get; set; }
        public string CodiModu { get; set; }

        public virtual UsuaSist CodiUsuaNavigation { get; set; }
    }
}
