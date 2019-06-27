using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteEnviPdf
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal PosiMail { get; set; }
        public string MailEnvi { get; set; }
        public string MailCc { get; set; }
        public string MailCco { get; set; }
        public string MailText { get; set; }
        public string HaceEnvi { get; set; }
        public string CodiEmex { get; set; }
        public string EstaMlpr { get; set; }
        public string MapeFrom { get; set; }
        public string MapeRef { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
