using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class UsuaEmpr
    {
        public string CodiUsua { get; set; }
        public decimal CodiEmpr { get; set; }
        public string CodiOfic { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual UsuaSist CodiUsuaNavigation { get; set; }
    }
}
