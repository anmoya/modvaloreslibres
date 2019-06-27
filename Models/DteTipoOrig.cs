using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteTipoOrig
    {
        public DteTipoOrig()
        {
            DteConfOrig = new HashSet<DteConfOrig>();
        }

        public string TipoOrig { get; set; }
        public string DescOrig { get; set; }

        public virtual ICollection<DteConfOrig> DteConfOrig { get; set; }
    }
}
