using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteEstaEnvi
    {
        public DteEstaEnvi()
        {
            BelConsCara = new HashSet<BelConsCara>();
            DteEnviDocu = new HashSet<DteEnviDocu>();
            DteEnviDocuH = new HashSet<DteEnviDocuH>();
            DtoReceDocu = new HashSet<DtoReceDocu>();
            LcvResuLibr = new HashSet<LcvResuLibr>();
        }

        public string EstaEnvi { get; set; }
        public string DescEsen { get; set; }
        public string ReviEnvi { get; set; }
        public string ReviDocu { get; set; }
        public string MensEsen { get; set; }
        public string MailEsen { get; set; }
        public string EnviCont { get; set; }
        public decimal? NumeEnvi { get; set; }
        public string HelpEsen { get; set; }
        public string CodiEmex { get; set; }

        public virtual ICollection<BelConsCara> BelConsCara { get; set; }
        public virtual ICollection<DteEnviDocu> DteEnviDocu { get; set; }
        public virtual ICollection<DteEnviDocuH> DteEnviDocuH { get; set; }
        public virtual ICollection<DtoReceDocu> DtoReceDocu { get; set; }
        public virtual ICollection<LcvResuLibr> LcvResuLibr { get; set; }
    }
}
