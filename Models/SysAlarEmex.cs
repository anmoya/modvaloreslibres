using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysAlarEmex
    {
        public string CodiEmex { get; set; }
        public string CodiAlar { get; set; }
        public string TipoAlar { get; set; }
        public string FrecAlar { get; set; }
        public string EstaAlar { get; set; }
        public decimal? PrioAlar { get; set; }
        public decimal IndiAlar { get; set; }
        public string CompAlar { get; set; }
        public decimal? ValoAlar { get; set; }
        public DateTime? FechAlar { get; set; }
        public DateTime? FesiAlar { get; set; }
        public decimal? DiavAlar { get; set; }
        public DateTime? FeavAlar { get; set; }
        public DateTime? FeasAlar { get; set; }
        public string StatAlar { get; set; }
        public string ErroAlar { get; set; }
        public string Sql2Alar { get; set; }
        public string MailInfo { get; set; }
        public string MailCccc { get; set; }

        public virtual SysAlar CodiAlarNavigation { get; set; }
    }
}
