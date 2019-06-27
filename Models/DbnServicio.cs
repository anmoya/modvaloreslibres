using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnServicio
    {
        public DbnServicio()
        {
            DbnServSrvd = new HashSet<DbnServSrvd>();
        }

        public string CodiServ { get; set; }
        public string DescServ { get; set; }
        public string ComaServ { get; set; }
        public string DetaServ { get; set; }
        public string OrigServ { get; set; }
        public string EstaOrig { get; set; }
        public string DestServ { get; set; }
        public string CodiDesp { get; set; }
        public string NombBrie { get; set; }
        public string AutoServ { get; set; }
        public decimal? DelaServ { get; set; }
        public decimal? MtryServ { get; set; }
        public decimal? ServOrde { get; set; }
        public string ServEnab { get; set; }
        public string ServIco1 { get; set; }
        public string ServIco2 { get; set; }
        public string ServIco3 { get; set; }

        public virtual ICollection<DbnServSrvd> DbnServSrvd { get; set; }
    }
}
