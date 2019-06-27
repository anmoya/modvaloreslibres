using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteEstaCesi
    {
        public DteEstaCesi()
        {
            DteCesiDocu = new HashSet<DteCesiDocu>();
        }

        public string EstaCesi { get; set; }
        public string DescCesi { get; set; }
        public string TipoEsta { get; set; }
        public string MensEsci { get; set; }
        public string MailEsci { get; set; }
        public decimal? NumeEnvi { get; set; }
        public string CodiEmex { get; set; }

        public virtual ICollection<DteCesiDocu> DteCesiDocu { get; set; }
    }
}
