using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysAlus
    {
        public string CodiAlar { get; set; }
        public string CodiUsua { get; set; }
        public string OrigAlus { get; set; }
        public string MailAlus { get; set; }
        public decimal? PrioAlus { get; set; }
        public string FrecAlus { get; set; }
        public string EstaAlus { get; set; }
        public decimal? IndiAlus { get; set; }
        public string CompAlus { get; set; }
        public decimal? ValoAlus { get; set; }
        public DateTime? FechAlus { get; set; }
        public DateTime? FesiAlus { get; set; }
        public DateTime? FeavAlus { get; set; }
        public decimal? DiavAlus { get; set; }
        public DateTime? FeasAlus { get; set; }
        public string StatAlus { get; set; }
        public string ErroAlus { get; set; }

        public virtual SysAlar CodiAlarNavigation { get; set; }
        public virtual UsuaSist CodiUsuaNavigation { get; set; }
    }
}
