using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysAlar
    {
        public SysAlar()
        {
            SysAlarEmex = new HashSet<SysAlarEmex>();
            SysAlarEmpr = new HashSet<SysAlarEmpr>();
            SysAlin = new HashSet<SysAlin>();
            SysAlri = new HashSet<SysAlri>();
            SysAlro = new HashSet<SysAlro>();
            SysAlus = new HashSet<SysAlus>();
        }

        public string CodiAlar { get; set; }
        public string DescAlar { get; set; }
        public string TipoAlar { get; set; }
        public string FrecAlar { get; set; }
        public string EstaAlar { get; set; }
        public decimal? PrioAlar { get; set; }
        public decimal? IndiAlar { get; set; }
        public string CompAlar { get; set; }
        public decimal? ValoAlar { get; set; }
        public DateTime? FechAlar { get; set; }
        public DateTime? FesiAlar { get; set; }
        public decimal? DiavAlar { get; set; }
        public DateTime? FeavAlar { get; set; }
        public DateTime? FeasAlar { get; set; }
        public string StatAlar { get; set; }
        public string ErroAlar { get; set; }
        public string AcciAlar { get; set; }
        public string ObjectName1 { get; set; }
        public string CodiModu { get; set; }
        public string ObjectName { get; set; }
        public string CodiUsua { get; set; }
        public string SqlcAlar { get; set; }
        public string SqliAlar { get; set; }
        public string Par1 { get; set; }
        public string Par2 { get; set; }
        public string Par3 { get; set; }
        public string Par4 { get; set; }
        public string Par5 { get; set; }
        public string Par6 { get; set; }
        public string Des1 { get; set; }
        public string Des2 { get; set; }
        public string Des3 { get; set; }
        public string Des4 { get; set; }
        public string Des5 { get; set; }
        public string Des6 { get; set; }
        public string Sql2Alar { get; set; }
        public string MailInfo { get; set; }
        public string SqldAlar { get; set; }
        public string CodiEmex { get; set; }
        public decimal? CodiEmpr { get; set; }

        public virtual ICollection<SysAlarEmex> SysAlarEmex { get; set; }
        public virtual ICollection<SysAlarEmpr> SysAlarEmpr { get; set; }
        public virtual ICollection<SysAlin> SysAlin { get; set; }
        public virtual ICollection<SysAlri> SysAlri { get; set; }
        public virtual ICollection<SysAlro> SysAlro { get; set; }
        public virtual ICollection<SysAlus> SysAlus { get; set; }
    }
}
