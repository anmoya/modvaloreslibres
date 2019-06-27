using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnRepoRous
    {
        public string CodiRepo { get; set; }
        public string CodiRous { get; set; }
        public string CodiModu { get; set; }
        public string ExptExls { get; set; }

        public virtual DbnListRepo CodiRepoNavigation { get; set; }
    }
}
