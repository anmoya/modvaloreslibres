using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteEstaDocu
    {
        public DteEstaDocu()
        {
            DteEncaDocu = new HashSet<DteEncaDocu>();
            DteEncaDocuH = new HashSet<DteEncaDocuH>();
            DtoEncaDocu = new HashSet<DtoEncaDocu>();
        }

        public string EstaDocu { get; set; }
        public string DescEsdo { get; set; }
        public string MensEsdo { get; set; }
        public string MailEsdo { get; set; }
        public string IndiCesi { get; set; }
        public string IndiImpr { get; set; }
        public string EnviCont { get; set; }
        public string HelpEsdo { get; set; }
        public string IndiLibr { get; set; }
        public string CodiEmex { get; set; }
        public string IndiClie { get; set; }

        public virtual ICollection<DteEncaDocu> DteEncaDocu { get; set; }
        public virtual ICollection<DteEncaDocuH> DteEncaDocuH { get; set; }
        public virtual ICollection<DtoEncaDocu> DtoEncaDocu { get; set; }
    }
}
