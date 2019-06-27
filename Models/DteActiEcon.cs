using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteActiEcon
    {
        public DteActiEcon()
        {
            DteAcecEmpr = new HashSet<DteAcecEmpr>();
        }

        public string CodiAcec { get; set; }
        public string DescAcec { get; set; }
        public string NombAcec { get; set; }
        public string CodiAcecSup { get; set; }

        public virtual ICollection<DteAcecEmpr> DteAcecEmpr { get; set; }
    }
}
